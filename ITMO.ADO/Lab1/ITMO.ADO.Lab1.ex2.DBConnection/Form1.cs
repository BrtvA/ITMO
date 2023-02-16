using System.Data;
using System.Data.OleDb;

namespace ITMO.ADO.Lab1.ex2.DBConnection
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
            catch
            {
                MessageBox.Show("������ ���������� � ����� ������");
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