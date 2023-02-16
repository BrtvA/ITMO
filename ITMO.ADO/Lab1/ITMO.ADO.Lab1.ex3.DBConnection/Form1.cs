using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace ITMO.ADO.Lab1.ex3.DBConnection
{
    public partial class Form1 : Form
    {
        OleDbConnection connection;
        string testConnect = @"Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Northwind;Data Source=.\SQLEXPRESS";
        public Form1()
        {
            InitializeComponent();
            connection = new OleDbConnection();
        }

        private void connectMenu_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = testConnect;
                    connection.Open();
                    MessageBox.Show("���������� � ����� ������ ��������� �������");
                }
                else
                    MessageBox.Show("���������� � ����� ������ ��� �����������");
            }
            catch (OleDbException XcpSQL)
            {
                //MessageBox.Show(XcpSQL.Message,
                //                "SQL Error code " + XcpSQL.ErrorCode,
                //                MessageBoxButtons.OK,
                //                MessageBoxIcon.Information);

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
                MessageBox.Show("���������� � ����� ������ �������");
            }
            else
                MessageBox.Show("���������� � ����� ������ ��� �������");
        }
    }
}