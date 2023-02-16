using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.ADO.Lab6.ex2.LoadDataSetXml
{
    public partial class Form1 : Form
    {
        DataSet northwindDataSet = new DataSet();

        public Form1()
        {
            InitializeComponent();
        }

        private void loadSchemaButton_Click(object sender, EventArgs e)
        {
            northwindDataSet.ReadXmlSchema("Northwind.xsd");

            customersGrid.DataSource = northwindDataSet.Tables["Customers"];
            ordersGrid.DataSource = northwindDataSet.Tables["Orders"];
        }

        private void loadDataButton_Click(object sender, EventArgs e)
        {
            northwindDataSet.ReadXml("Northwind.xml");
        }
    }
}