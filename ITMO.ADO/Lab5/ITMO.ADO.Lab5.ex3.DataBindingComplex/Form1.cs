using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.ADO.Lab5.ex3.DataBindingComplex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bindGridButton_Click(object sender, EventArgs e)
        {
            productsTableAdapter1.Fill(northwindDataSet1.Products);
            BindingSource productsBindingSource = new BindingSource(northwindDataSet1, "Products");

            productsGrid.DataSource = productsBindingSource;

            bindingNavigator1.BindingSource = productsBindingSource;
        }
    }
}