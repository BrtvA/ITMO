using ITMO.ADO.DBManager.AdoStudio.Models;
using ITMO.ADO.DBManager.AdoStudio.Views;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ITMO.ADO.DBManager.AdoStudio.ViewModels
{
    class LoginViewModel : BaseViewModel
    {
        private LoginModel loginModel = new LoginModel();
        private LoginModel configModel = new LoginModel();

        public LoginViewModel()
        {
            ServerConnection.GetConnectionStringByName("MyConnectionString");

            configModel.ServerName = Regex.Match(ServerConnection.connectionString, @"(?<=Server=)(.*)(?=; Database=)").Value;
            configModel.DataBaseName = Regex.Match(ServerConnection.connectionString, @"(?<=; Database=)(.*)(?=; Trusted_Connection=)").Value;
            configModel.UserName = Regex.Match(ServerConnection.connectionString, @"(?<=; User ID=)(.*)(?=; Password=)").Value;
            configModel.Password = Regex.Match(ServerConnection.connectionString, @"(?<=; Password=)(.*)(?=; TrustServerCertificate)").Value;
            configModel.TrustedConnection = (configModel.UserName == "") & (configModel.Password == "");

            TrustedConnection = configModel.TrustedConnection;
            ServerName = configModel.ServerName;
            DataBaseName = configModel.DataBaseName;
            UserName = configModel.UserName;
            Password = configModel.Password;

            ConnectCommand = new RelayCommand(obj => ConnectToDB((LoginWindow)obj), 
                                              obj => CanExcecuteConnectCommand);
        }

        #region Properties
        public string ServerName
        {
            get { return loginModel.ServerName ?? ""; }
            set
            {
                loginModel.ServerName = value.Trim();
                OnPropertyChanged(nameof(ServerName));
            }
        }

        public string DataBaseName
        {
            get { return loginModel.DataBaseName ?? ""; }
            set
            {
                loginModel.DataBaseName = value.Trim();
                OnPropertyChanged(nameof(DataBaseName));
            }
        }

        public bool TrustedConnection
        {
            get { return loginModel.TrustedConnection;}
            set
            {
                loginModel.TrustedConnection = value;
                OnPropertyChanged(nameof(TrustedConnection));
            }
        }

        public bool UserConnection
        {
            get { return !loginModel.TrustedConnection;}
        }

        public string UserName
        {
            get { return loginModel.UserName ?? ""; }
            set
            {
                loginModel.UserName = value.Trim();
                OnPropertyChanged(nameof(UserName));
            }
        }

        public string Password
        {
            get { return loginModel.Password ?? ""; }
            set
            {
                loginModel.Password = value.Trim();
                OnPropertyChanged(nameof(Password));
            }
        }
        #endregion

        #region Commands
        public RelayCommand ConnectCommand { get; }

        public bool CanExcecuteConnectCommand
        {
            get
            {
                return ServerName.Length > 0 & DataBaseName.Length > 0
                     & (TrustedConnection | !TrustedConnection & UserName.Length > 0 & Password.Length > 0);
            }
        }

        public void ConnectToDB(LoginWindow loginWindow)
        {
            string connectionString;
            bool rewritingConnectionString;

            if (TrustedConnection)
            {
                connectionString = $"Server={ServerName}; Database={DataBaseName}; Trusted_Connection=True; TrustServerCertificate=True";
            }
            else
            {
                connectionString = $"Server={ServerName}; Database={DataBaseName}; Trusted_Connection=True; User ID={UserName}; Password={Password}; TrustServerCertificate=True";
            }
            rewritingConnectionString = (ServerName != configModel.ServerName) | (DataBaseName != configModel.DataBaseName) | (UserName != configModel.UserName) | (Password != configModel.Password) | (TrustedConnection != configModel.TrustedConnection);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    if (rewritingConnectionString)
                    {
                        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                        var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                        connectionStringsSection.ConnectionStrings["MyConnectionString"].ConnectionString = connectionString;
                        config.Save();
                        ConfigurationManager.RefreshSection("connectionStrings");
                        
                        ServerConnection.connectionString = connectionString;
                    }

                    DataWindow dataWindow = new DataWindow();
                    dataWindow.Show();
                    loginWindow.Close();

                    //Application.Current.MainWindow.Close();
                }
                catch (SqlException ex)
                {
                    foreach (SqlError sqlError in ex.Errors)
                    {
                        MessageBox.Show(sqlError.Message,
                                        "SQL Error code " + sqlError.Number,
                                        MessageBoxButton.OK,
                                        MessageBoxImage.Error);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion
    }
}
