using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.ADO.Lab4.ex1.DatasetDesigner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getCustomersButton_Click(object sender, EventArgs e)
        {
            NorthwindDataSet northwindDataset1 = new NorthwindDataSet();

            NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter1 =
                new NorthwindDataSetTableAdapters.CustomersTableAdapter();

            customersTableAdapter1.Fill(northwindDataset1.Customers);

            foreach (NorthwindDataSet.CustomersRow NWCustomer in
                             northwindDataset1.Customers.Rows)
            {
                customersListBox.Items.Add(NWCustomer.CompanyName);
            }
        }
    }
}
