using System.Data;
using System.Data.OleDb;
using System.Configuration;

namespace ITMO.ADO.Lab1.ex5.DBConnection
{
    public partial class Form1 : Form
    {
        OleDbConnection connection;
        string testConnect = GetConnectionStringByName("DBConnect.NorthwindConnectionString");
        //string testConnect = @"Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Northwind;Data Source=.\SQLEXPRESS";

        public Form1()
        {
            InitializeComponent();
            connection = new OleDbConnection();
            this.connection.StateChange 
                += new System.Data.StateChangeEventHandler(this.connection_StateChange);

        }

        static string GetConnectionStringByName(string name)
        {
            string returnValue = null;
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];
            if (settings != null)
                returnValue = settings.ConnectionString;
            return returnValue;
        }

        private void connection_StateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            connectMenu.Enabled = (e.CurrentState == ConnectionState.Closed);
            disconnectMenu.Enabled = (e.CurrentState == ConnectionState.Open);
        }


        private void connectMenu_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = testConnect;
                    connection.Open();
                    MessageBox.Show("?????????? ? ????? ?????? ????????? ???????");
                }
                else
                    MessageBox.Show("?????????? ? ????? ?????? ??? ???????????");
            }
            catch (OleDbException XcpSQL)
            {
                foreach (OleDbError se in XcpSQL.Errors)
                {
                    MessageBox.Show(se.Message,
                    "SQL Error code " + se.NativeError,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
            }
            catch (Exception Xcp)
            {
                MessageBox.Show(Xcp.Message, 
                                "Unexpected Exception",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void disconnectMenu_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("?????????? ? ????? ?????? ???????");
            }
            else
                MessageBox.Show("?????????? ? ????? ?????? ??? ???????");
        }

        private void listConnectionMenu_Click(object sender, EventArgs e)
        {
            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;
            if (settings != null)
            {
                foreach (ConnectionStringSettings cs in settings)
                {
                    MessageBox.Show("name = " + cs.Name);
                    MessageBox.Show("providerName = " + cs.ProviderName);
                    MessageBox.Show("connectionString = " + cs.ConnectionString);
                }
            }
        }
    }
}