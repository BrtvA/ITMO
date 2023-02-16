using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ITMO.DesktopCSharp.WPF.Calculator.CalcApp
{
    /// <summary>
    /// Логика взаимодействия для EquationWindow.xaml
    /// </summary>
    public partial class EquationWindow : Window
    {
        public double ACoefficient
        {
            get 
            {
                if (aTxtBox.Text == "")
                    return 0;
                else
                    return Convert.ToDouble(aTxtBox.Text); 
            }
            //set { aTxtBox.Text = value.ToString(); }
        }

        public double BCoefficient
        {
            get
            {
                if (bTxtBox.Text == "")
                    return 0;
                else
                    return Convert.ToDouble(bTxtBox.Text);
            }
            //set { bTxtBox.Text = value.ToString(); }
        }

        public double CCoefficient
        {
            get
            {
                if (cTxtBox.Text == "")
                    return 0;
                else
                    return Convert.ToDouble(cTxtBox.Text);
            }
            //set { cTxtBox.Text = value.ToString(); }
        }
        
        public EquationWindow()
        {
            InitializeComponent();
        }

        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            Button? btn = e.Source as Button;
            if (btn != null)
            {
                switch (btn.Name.ToString())
                {
                    case "solveBtn":
                        if (ACoefficient != 0 && BCoefficient != 0 && CCoefficient != 0)
                            this.DialogResult = true;
                        break;
                    case "cancelBtn":
                        this.DialogResult = false;
                        break;
                }
            }
        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox? textBox= e.Source as TextBox;
            if (textBox!=null)
            {
                if (!(((int)e.Key >= 34) && ((int)e.Key <= 43)) && 
                    !(((int)e.Key >= 74) && ((int)e.Key <= 83)) && 
                    (int)e.Key != 142 && (int)e.Key != 143)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
