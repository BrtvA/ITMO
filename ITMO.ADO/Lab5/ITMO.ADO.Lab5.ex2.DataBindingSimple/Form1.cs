using ITMO.ADO.Lab5.ex2.DataBindingSimple.NorthwindDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.ADO.Lab5.ex2.DataBindingSimple
{
    public partial class Form1 : Form
    {
        private BindingSource productsBindingSource;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            productsDataAdapter.Fill(northwindDataSet1.Products);
            productsBindingSource = new BindingSource(northwindDataSet1, "Products");

            productIDTextBox.DataBindings.Add("Text", productsBindingSource, "ProductID");
            productNameTextBox.DataBindings.Add("Text", productsBindingSource, "ProductName");
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            productsBindingSource.MovePrevious();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            productsBindingSource.MoveNext();
        }
    }
}
