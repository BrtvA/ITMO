using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ITMO.DesktopCSharp.WinForms.Lab06.Ex01
{
    public partial class Form1 : Form
    {
        public double a, b;

        public string DataA
        {
            get
            {
                return aTextBox.Text;
            }
            set
            {
                aTextBox.Text = value;
            }
        }

        public string DataB
        {
            get
            {
                return bTextBox.Text;
            }
            set
            {
                bTextBox.Text = value;
            }
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            double t = 0;
            Point p1, p2;
            int w = (int)panel.Width;
            int h = (int)panel.Height;
            int y = h / 2;

            for (int x = 0; x < w; x++)
            {
                p1 = new Point(x, y);
                t = Operation.SummSin(x, a, b);
                y = (int)(t * h / 5);
                y = y + h / 2;
                p2 = new Point(x, y);
                Graphics dc = e.Graphics;
                Pen p = new Pen(Color.Red, 1);
                dc.DrawLine(p, p1, p2);
            }
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(DataA);
                b = double.Parse(DataB);
                panel.Refresh();
            }
            catch (Exception er)
            {
                MessageBox.Show("При выполнении ввода исходных данных возникла ошибка: \n" + 
                                er.Message,"Ошибка",
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
                return;
            }
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            EditForm editF = new EditForm();
            editF.Show(this);
        }

        public Form1()
        {
            InitializeComponent();
            a = 0.1;
            b = 0.04;
        }
    }
}
