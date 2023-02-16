using ITMO.ADO.DBManager.AdoStudio.Models;
using ITMO.ADO.DBManager.AdoStudio.Views;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ITMO.ADO.DBManager.AdoStudio.ViewModels
{
    class DataViewModel : BaseViewModel
    {
        const string tableName = "Query";

        DataSet dataSet = new DataSet();
        SqlDataAdapter adapter;
        DataTable dataTable;
        SqlCommandBuilder commands;

        const string sql0 = "SELECT * FROM TransactionDetails.Transactions";
        const string sql1 = "SELECT * FROM CustomerDetails.Customers";
        const string sql2 = "SELECT * FROM ShareDetails.Shares";
        const string sql3 = "SELECT TransactionDetails.Transactions.TransactionId, "
                                 + "CustomerDetails.Customers.CustomerFirstName, "
                                 + "CustomerDetails.Customers.CustomerOtherInitials, "
                                 + "CustomerDetails.Customers.CustomerLastName, "
                                 + "TransactionDetails.Transactions.TransactionType, "
                                 + "TransactionDetails.Transactions.DateEntered, "
                                 + "TransactionDetails.Transactions.Amount, "
                                 + "TransactionDetails.Transactions.ReferenceDetails, "
                                 + "TransactionDetails.Transactions.Notes, "
                                 + "ShareDetails.Shares.ShareDesc, "
                                 + "ShareDetails.Shares.CurrentPrice "
                         + "FROM TransactionDetails.Transactions "
                         + "LEFT JOIN CustomerDetails.Customers "
                                 + "ON TransactionDetails.Transactions.CustomerId = CustomerDetails.Customers.CustomerId "
                         + "LEFT JOIN ShareDetails.Shares "
                                 + "ON TransactionDetails.Transactions.RelatedShareId = ShareDetails.Shares.ShareID";

        List<string> sqlList = new List<string>()
        {
            sql0,
            sql1,
            sql2,
            sql3
        };

        public DataViewModel()
        {
            RefreshData();

            ChooseTableCommand = new RelayCommand(obj => RefreshData(),
                                                  obj => true);
            SaveToDBCommand = new RelayCommand(obj => SaveToDB(),
                                               obj => SelectedIndexBox != 3);
            RefreshFromDBCommand = new RelayCommand(obj => RefreshData(),
                                                   obj => true);
            DisconnectCommand = new RelayCommand(obj => Disconnect((DataWindow)obj),
                                                 obj => true);
        }

        #region Properties

        private int selectedIndex = 0;
        public int SelectedIndexBox
        {
            get { return selectedIndex; }
            set
            {
                selectedIndex= value;
                OnPropertyChanged(nameof(SelectedIndexBox));
            }
        }

        private DataView tableDataView;
        public DataView TableDataView
        {
            get { return tableDataView; }
            set
            {
                tableDataView = value;
                OnPropertyChanged(nameof(TableDataView));
            }
        }

        #endregion

        #region Commands

        public RelayCommand ChooseTableCommand { get; }

        public RelayCommand SaveToDBCommand { get; }

        private void SaveToDB()
        {
            if (dataSet.Tables.Count > 0)
            {
                try
                {
                    dataSet.EndInit();
                    adapter.Update(dataSet.Tables[tableName]);

                    MessageBox.Show("Данные перезаписаны");
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
            }
        }

        public RelayCommand RefreshFromDBCommand { get; }
        public void RefreshData()
        {
            try
            {
                adapter = new SqlDataAdapter(sqlList[SelectedIndexBox], ServerConnection.connectionString);
                dataTable = new DataTable(tableName);
                dataSet.Tables.Clear();
                dataSet.Tables.Add(dataTable);
                adapter.Fill(dataSet.Tables[tableName]);
                commands = new SqlCommandBuilder(adapter);
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

            if (dataSet.Tables.Count > 0)
            {
                TableDataView = dataSet.Tables[0].DefaultView;
            }
        }

        public RelayCommand DisconnectCommand { get; }

        private void Disconnect(DataWindow dataWindow) 
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            dataWindow.Close();

            dataSet.Dispose();
            adapter.Dispose();
            dataTable.Dispose();
            tableDataView.Dispose();
            commands.Dispose();
        }

        #endregion
    }
}
