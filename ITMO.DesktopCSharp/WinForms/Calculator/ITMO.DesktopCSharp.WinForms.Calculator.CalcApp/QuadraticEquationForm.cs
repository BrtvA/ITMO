using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.DesktopCSharp.WinForms.Calculator.CalcApp
{
    public partial class QuadraticEquationForm : Form
    {
        public double ACoefficient
        {
            get { return Convert.ToDouble(aTextBox.Text);}
            set { aTextBox.Text = value.ToString(); }
        }

        public double BCoefficient
        {
            get { return Convert.ToDouble(bTextBox.Text); }
            set { bTextBox.Text = value.ToString(); }
        }

        public double CCoefficient
        {
            get { return Convert.ToDouble(cTextBox.Text); }
            set { cTextBox.Text = value.ToString(); }
        }

        public QuadraticEquationForm()
        {
            InitializeComponent();
        }

        private void сoefficientTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44 && e.KeyChar != ',' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }
    }
}
