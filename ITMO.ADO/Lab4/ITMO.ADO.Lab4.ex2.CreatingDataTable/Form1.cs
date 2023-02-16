using System.Data;

namespace ITMO.ADO.Lab4.ex2.CreatingDataTable
{
    public partial class Form1 : Form
    {
        private DataTable customersTable = new DataTable("Customers");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tableGrid.DataSource = customersTable;

            customersTable.Columns.Add("CustomerID", Type.GetType("System.String"));
            customersTable.Columns.Add("CompanyName", Type.GetType("System.String"));
            customersTable.Columns.Add("ContactName", Type.GetType("System.String"));
            customersTable.Columns.Add("ContactTitle", Type.GetType("System.String"));
            customersTable.Columns.Add("Address", Type.GetType("System.String"));
            customersTable.Columns.Add("City", Type.GetType("System.String"));
            customersTable.Columns.Add("Country", Type.GetType("System.String"));
            customersTable.Columns.Add("Phone", Type.GetType("System.String"));

            //DataColumn[] KeyColumns = new DataColumn[1];
            //KeyColumns[0] = customersTable.Columns["CustomerID"];
            //customersTable.PrimaryKey = KeyColumns;

            customersTable.Columns["CustomerID"].AllowDBNull = false;
            customersTable.Columns["CompanyName"].AllowDBNull = false;
        }

        private void addRowButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow custRow = customersTable.NewRow();
                Object[] custRecord =  {"ALFKI", "Alfreds Futterkiste", "Maria Anders",
                                    "Sales Representative", "Obere Str. 57", "Berlin",
                                    "Germany", "030-0074321"};
                custRow.ItemArray = custRecord;

                customersTable.Rows.Add(custRow);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}