using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.DesktopCSharp.WinForms.Lab04.Ex05
{
    public partial class Form2 : Form
    {
        private double shift = 0.1;

        public double BoundaryLeft
        {
            get 
            {
                if (!double.TryParse(boundary1TextBox.Text, out double a))
                {
                    return 0;
                }
                else
                {
                    return Convert.ToDouble(boundary1TextBox.Text);
                }
            }
        }

        public double BoundaryRight
        {
            get 
            {
                if (!double.TryParse(boundary2TextBox.Text, out double a))
                {
                    return 0;
                }
                else
                {
                    return Convert.ToDouble(boundary2TextBox.Text);
                }
            }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void transferDataBtn_Click(object sender, EventArgs e)
        {
            if (BoundaryLeft > BoundaryRight || BoundaryLeft == 0 && BoundaryRight == 0)
            {
                MessageBox.Show("Правая граница диапазона \n должна быть больше левой");
                return;
            }

            double x;
            int stepCount = (int)((BoundaryRight - BoundaryLeft) / shift)+1;

            StringBuilder s= new StringBuilder();
            for (int i =0; i<stepCount; i++)
            {
                x = BoundaryLeft + i * shift;
                s.Append($"{Math.Round(x,2)}: {Math.Round(Math.Sin(x), 2)} \n");
            }

            Form1 frm1 = this.Owner as Form1;
            if (frm1 != null)
            {
                frm1.PointData = s.ToString();
                frm1.Interval = $"Левая граница: {BoundaryLeft}; правая граница: {BoundaryRight}";
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boundaryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44 && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }
    }
}
