using Microsoft.Data.SqlClient;
using System.Data;

namespace ITMO.ADO.Lab4.ex4.DataAdapterProgram
{
    public partial class Form1 : Form
    {
        private SqlConnection NorthwindConnection = 
            new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True; TrustServerCertificate=True");

        private SqlDataAdapter SqlDataAdapter1;

        private DataSet NorthwindDataset = new DataSet("Northwind");
        private DataTable CustomersTable = new DataTable("Customers");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter1 = new SqlDataAdapter("SELECT * FROM Customers", NorthwindConnection);
            NorthwindDataset.Tables.Add(CustomersTable);
            SqlDataAdapter1.Fill(NorthwindDataset.Tables["Customers"]);
            dataGridView1.DataSource = NorthwindDataset.Tables["Customers"];

            SqlCommandBuilder commands = new SqlCommandBuilder(SqlDataAdapter1);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            NorthwindDataset.EndInit();
            SqlDataAdapter1.Update(NorthwindDataset.Tables["Customers"]);
        }
    }
}