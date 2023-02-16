using ITMO.DesktopCSharp.WinForms.Calculator.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ITMO.DesktopCSharp.WPF.Calculator.CalcApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string oneOut = "1";
        private const string twoOut = "2";
        private const string threeOut = "3";
        private const string fourOut = "4";
        private const string fiveOut = "5";
        private const string sixOut = "6";
        private const string sevenOut = "7";
        private const string eightOut = "8";
        private const string nineOut = "9";
        private const string zeroOut = "0";

        private bool IsEngineering;

        private string[] nameEngineeringBtn;
        private string[] nameToolTip;

        private Button btn;

        private string VersionInfo
        {
            set { versionTxtBlock.Text = value; }
        }

        private string DisplayText
        {
            get { return displayTxtBlock.Text; }
            set { displayTxtBlock.Text = value; }
        }

        private string SwitchHeader
        {
            get { return switchBtn.Header.ToString(); }
            set { switchBtn.Header = value; }
        }

        public MainWindow()
        {
            InitializeComponent();

            VersionInfo = CalcEngine.GetVersion();
            DisplayText = "0";

            IsEngineering = false;

            nameEngineeringBtn = new string[] { "^", "^2", "√", "∛", "1/x", "Equation", "!" };
            nameToolTip = new string[] 
            {
                "Raising a number to a power",
                "Raising a number to a power of 2",
                "Get the square root of a number",
                "Get the cube root of a number",
                "Get the inversion",
                "Open the dialog result for solving a quadratic equation",
                "Get the factorial of a number"
            };
        }

        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            Button? button = e.Source as Button;
            if (button != null)
            {
                switch (button.Tag.ToString())
                {
                    case "0": // 0
                        DisplayText = CalcEngine.CalcNumber(zeroOut);
                        break;
                    case "1": // 1
                        DisplayText = CalcEngine.CalcNumber(oneOut);
                        break;
                    case "2": // 2
                        DisplayText = CalcEngine.CalcNumber(twoOut);
                        break;
                    case "3": // 3
                        DisplayText = CalcEngine.CalcNumber(threeOut);
                        break;
                    case "4": // 4
                        DisplayText = CalcEngine.CalcNumber(fourOut);
                        break;
                    case "5": // 5
                        DisplayText = CalcEngine.CalcNumber(fiveOut);
                        break;
                    case "6": // 6
                        DisplayText = CalcEngine.CalcNumber(sixOut);
                        break;
                    case "7": // 7
                        DisplayText = CalcEngine.CalcNumber(sevenOut);
                        break;
                    case "8": // 8
                        DisplayText = CalcEngine.CalcNumber(eightOut);
                        break;
                    case "9": // 9
                        DisplayText = CalcEngine.CalcNumber(nineOut);
                        break;
                    case "10":// Date
                        DisplayText = CalcEngine.GetDate();
                        CalcEngine.CalcReset();
                        break;
                    case "11":// C
                        CalcEngine.CalcReset();
                        DisplayText = "0";
                        break;
                    case "12":// /
                        CalcEngine.CalcOperation(CalcEngine.Operator.eDivide);
                        break;
                    case "13":// ^
                        CalcEngine.CalcOperation(CalcEngine.Operator.eExponentiation);
                        break;
                    case "14":// X
                        CalcEngine.CalcOperation(CalcEngine.Operator.eMultiply);
                        break;
                    case "15":// ^2
                        CalcEngine.CalcOperation(CalcEngine.Operator.eSquare);
                        break;
                    case "16":// -
                        CalcEngine.CalcOperation(CalcEngine.Operator.eSubtract);
                        break;
                    case "17":// √
                        CalcEngine.CalcOperation(CalcEngine.Operator.eSqrt);
                        break;
                    case "18":// +
                        CalcEngine.CalcOperation(CalcEngine.Operator.eAdd);
                        break;
                    case "19":// ∛
                        CalcEngine.CalcOperation(CalcEngine.Operator.eCubrt);
                        break;
                    case "20":// .
                        DisplayText = CalcEngine.CalcDecimal();
                        break;
                    case "21":// +/-
                        DisplayText = CalcEngine.CalcSign();
                        break;
                    case "22":// =
                        DisplayText = CalcEngine.CalcEqual();
                        CalcEngine.CalcReset();
                        break;
                    case "23":// 1/x
                        CalcEngine.CalcOperation(CalcEngine.Operator.eInverse);
                        break;
                    case "24":// QE
                        EquationWindow equationWindow = new EquationWindow();
                        //equationWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                        var location = this.PointToScreen(new Point(0, 0));
                        equationWindow.Left = location.X + this.Width;
                        equationWindow.Top = location.Y;
                        if (equationWindow.ShowDialog() != true)
                            return;
                        DisplayText = CalcEngine.CalcQuadraticEquation(equationWindow.ACoefficient,
                                                                       equationWindow.BCoefficient,
                                                                       equationWindow.CCoefficient);
                        break;
                    case "25":// !
                        CalcEngine.CalcOperation(CalcEngine.Operator.eFactorial);
                        break;
                }
            }
            //MessageBox.Show($"{button.Tag.ToString()}");
        }

        private async void KeyEqual_Click(object sender, RoutedEventArgs e)
        {
            DisplayText = await Task.Run(()=>CalcEngine.CalcEqual());
            CalcEngine.CalcReset();
            e.Handled= true;
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            MenuItem? menu = e.Source as MenuItem;
            if (menu != null)
            {
                switch (menu.Tag.ToString())
                {
                    case "26":// Exit
                        this.Close();
                        break;
                    case "27":// Switch
                        if (IsEngineering)
                        {
                            IsEngineering = false;
                            SwitchHeader = "Switch to Engineering";
                            
                            int index = 25;
                            for(int i = 0; i < 7; i++)
                            {
                                buttonGrid.Children.RemoveAt(index);
                                index--;
                            }
                            buttonGrid.ColumnDefinitions.RemoveAt(4);
                            buttonGrid.RowDefinitions.RemoveAt(5);

                            displayBorder.Width = 300;
                        }
                        else
                        {
                            IsEngineering = true;
                            SwitchHeader = "Switch to Standart";
                            buttonGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(75) });
                            buttonGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(75) });

                            int tag = 13;
                            for (int i=0;i<5;i++)
                            {
                                btn = new Button();
                                btn.Content = nameEngineeringBtn[i];
                                btn.Tag = tag;
                                btn.ToolTip = nameToolTip[i];

                                Grid.SetColumn(btn, 4);
                                Grid.SetRow(btn, i);

                                if (tag < 19)
                                    tag += 2;
                                else
                                    tag += 4;

                                buttonGrid.Children.Add(btn);
                            }

                            btn = new Button();
                            btn.Content = nameEngineeringBtn[5];
                            btn.ToolTip = nameToolTip[5];
                            btn.Tag = 24;
                            Grid.SetColumn(btn, 0);
                            Grid.SetRow(btn, 5);
                            Grid.SetColumnSpan(btn, 4);
                            buttonGrid.Children.Add(btn);

                            btn = new Button();
                            btn.Content = nameEngineeringBtn[6];
                            btn.ToolTip = nameToolTip[6];
                            btn.Tag = 25;
                            Grid.SetColumn(btn, 4);
                            Grid.SetRow(btn, 5);
                            buttonGrid.Children.Add(btn);

                            displayBorder.Width = 375;
                        }
                        break;
                }
            }
        }
    }
}
