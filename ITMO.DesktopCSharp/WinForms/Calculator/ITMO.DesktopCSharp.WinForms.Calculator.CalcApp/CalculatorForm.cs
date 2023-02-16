using ITMO.DesktopCSharp.WinForms.Calculator.Engine;
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
    public partial class CalculatorForm : Form
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

        public string DisplayText
        {
            get { return OutputDisplay.Text; }
            set { OutputDisplay.Text = value; }
        }

        public bool KeyPowVisible
        {
            get { return KeyPow.Visible; }
            set { KeyPow.Visible = value; }
        }

        public bool KeySquareVisible
        {
            get { return KeySquare.Visible; }
            set { KeySquare.Visible = value; }
        }

        public bool KeySqrtVisible
        {
            get { return KeySqrt.Visible; }
            set { KeySqrt.Visible = value; }
        }

        public bool KeyCubrtVisible
        {
            get { return KeyCubrt.Visible; }
            set { KeyCubrt.Visible = value;}
        }

        public bool KeyInverseVisible
        {
            get { return KeyInverse.Visible; }
            set { KeyInverse.Visible = value; }
        }

        public bool KeyQuadraticEquationVisible
        {
            get { return KeyQuadraticEquation.Visible; }
            set { KeyQuadraticEquation.Visible = value;}
        }

        public bool KeyFactorialVisible
        {
            get { return KeyFactorial.Visible; }
            set { KeyFactorial.Visible = value;}
        }

        public CalculatorForm()
        {
            InitializeComponent();

            VersionInfo.Text = CalcEngine.GetVersion();
            DisplayText = "0";

            ChangeVisible(false);
        }

        protected async void KeyEqual_ClickAsync(object sender, System.EventArgs e)
        {
            DisplayText = await Task.Run(() => CalcEngine.CalcEqual());
            CalcEngine.CalcReset();
        }

        protected void KeyStandart_Click(object sender, System.EventArgs e)
        {
            Button? button= sender as Button;
            if (button != null)
            {
               DoStandartAction((string)button.Tag);
            }
        }

        private void DoStandartAction(string tag)
        {
            switch (tag)
            {
                case "1": // Date
                    DisplayText = CalcEngine.GetDate();
                    CalcEngine.CalcReset();
                    break;
                case "2": // C
                    CalcEngine.CalcReset();
                    DisplayText = "0";
                    break;
                case "3": // /
                    CalcEngine.CalcOperation(CalcEngine.Operator.eDivide);
                    break;
                case "4": // 7
                    DisplayText = CalcEngine.CalcNumber(sevenOut);
                    break;
                case "5": // 8
                    DisplayText = CalcEngine.CalcNumber(eightOut);
                    break;
                case "6": // 9
                    DisplayText = CalcEngine.CalcNumber(nineOut);
                    break;
                case "7": // x
                    CalcEngine.CalcOperation(CalcEngine.Operator.eMultiply);
                    break;
                case "8": // 4
                    DisplayText = CalcEngine.CalcNumber(fourOut);
                    break;
                case "9": // 5
                    DisplayText = CalcEngine.CalcNumber(fiveOut);
                    break;
                case "10": // 6
                    DisplayText = CalcEngine.CalcNumber(sixOut);
                    break;
                case "11": // -
                    CalcEngine.CalcOperation(CalcEngine.Operator.eSubtract);
                    break;
                case "12": // 1
                    DisplayText = CalcEngine.CalcNumber(oneOut);
                    break;
                case "13": // 2
                    DisplayText = CalcEngine.CalcNumber(twoOut);
                    break;
                case "14": // 3
                    DisplayText = CalcEngine.CalcNumber(threeOut);
                    break;
                case "15": // +
                    CalcEngine.CalcOperation(CalcEngine.Operator.eAdd);
                    break;
                case "16": // 0
                    DisplayText = CalcEngine.CalcNumber(zeroOut);
                    break;
                case "17": // .
                    DisplayText = CalcEngine.CalcDecimal();
                    break;
                case "18": // +/-
                    DisplayText = CalcEngine.CalcSign();
                    break;
                case "19": // =
                    DisplayText = CalcEngine.CalcEqual();
                    CalcEngine.CalcReset();
                    break;
            }
        }

        protected void KeyAdditional_Click(object sender, System.EventArgs e)
        {
            Button? button = sender as Button;
            if (button != null)
            {
                DoAdditionalAction((string)button.Tag);
            }
        }

        private void DoAdditionalAction(string tag)
        {
            switch (tag)
            {
                case "20": // ^
                    CalcEngine.CalcOperation(CalcEngine.Operator.eExponentiation);
                    break;
                case "21": // ^2
                    CalcEngine.CalcOperation(CalcEngine.Operator.eSquare);
                    break;
                case "22": // √
                    CalcEngine.CalcOperation(CalcEngine.Operator.eSqrt);
                    break;
                case "23": // ∛
                    CalcEngine.CalcOperation(CalcEngine.Operator.eCubrt);
                    break;
                case "24": // 1/x
                    CalcEngine.CalcOperation(CalcEngine.Operator.eInverse);
                    break;
                case "25": // QE
                    QuadraticEquationForm qeForm = new QuadraticEquationForm();
                    qeForm.StartPosition = FormStartPosition.Manual;
                    qeForm.Location = new Point(this.Location.X + this.Width, this.Location.Y);
                    if (qeForm.ShowDialog() != DialogResult.OK)
                        return;
                    DisplayText = CalcEngine.CalcQuadraticEquation(qeForm.ACoefficient, 
                                                                   qeForm.BCoefficient,
                                                                   qeForm.CCoefficient);
                    break;
                case "26": // !
                    CalcEngine.CalcOperation(CalcEngine.Operator.eFactorial);
                    break;
            }
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem? menuItem= sender as ToolStripMenuItem;
            if (menuItem != null)
            {
                DoMenuAction((string)menuItem.Tag);
            }
        }

        private void DoMenuAction(string tag)
        {
            switch (tag)
            {
                case "27": // Exit
                    this.Close();
                    break;
                case "28": // Standart
                    ChangeVisible(false);
                    break;
                case "29": // Additional
                    ChangeVisible(true);
                    break;
            }
        }

        private void ChangeVisible(bool visible)
        {
            KeyPowVisible = visible;
            KeySquareVisible = visible;
            KeySqrtVisible = visible;
            KeyCubrtVisible = visible;
            KeyInverseVisible = visible;
            KeyQuadraticEquationVisible = visible;
            KeyFactorialVisible = visible;

            if (visible)
            {
                this.Height = 732;
                this.Width = 345;
            }
            else
            {
                this.Height = 571;
                this.Width = 345;
            }
        }

        private void OutputDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
