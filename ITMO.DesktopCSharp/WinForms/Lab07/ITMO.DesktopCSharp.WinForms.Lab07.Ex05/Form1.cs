namespace ITMO.DesktopCSharp.WinForms.Lab07.Ex05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string GoButt()
        {
            int maxValue = 0;
            System.Text.StringBuilder resultText = new System.Text.StringBuilder();
            if (int.TryParse(maxNumber.Text, out maxValue))
            {
                for (int trial = 2; trial <= maxValue; trial++)
                {
                    bool isPrime = true;
                    for (int divisor = 2; divisor <= Math.Sqrt(trial); divisor++)
                    {
                        if (trial % divisor == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        resultText.AppendFormat("{0} ", trial);
                    }
                }
            }
            else
            {
                resultText.Append("Unable to parse maximum value.");
            }
            return resultText.ToString();
        }

        private async void caclBtn_Click(object sender, EventArgs e)
        {
            richTextBox.Text = await Task.Run(() => GoButt());
        }
    }
}