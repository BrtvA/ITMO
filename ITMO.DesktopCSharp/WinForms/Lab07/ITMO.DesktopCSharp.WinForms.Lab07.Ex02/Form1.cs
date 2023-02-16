namespace ITMO.DesktopCSharp.WinForms.Lab07.Ex02
{
    public partial class Form1 : Form
    {
        private delegate void TimeConsumingMethodDelegate(int seconds);
        public delegate void SetProgressDelegate(int val);

        bool Cancel;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("���� ������ ��������� �����");
            }
        }

        private void TimeConsumingMethod(int seconds)
        {
            for (int j = 1; j <= seconds; j++)
            {
                if (Cancel)
                    break;
                System.Threading.Thread.Sleep(1000);
                SetProgress((int)(j * 100) / seconds);
            }

            if (Cancel)
            {
                System.Windows.Forms.MessageBox.Show("Cancelled");
                Cancel = false;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Complete");
            }
        }

        public void SetProgress(int val)
        {
            if (progressBar1.InvokeRequired)
            {
                SetProgressDelegate del = new SetProgressDelegate(SetProgress);
                this.Invoke(del, new object[] { val });
            }
            else
            {
                progressBar1.Value = val;
            }
        }

        private async void startBtn_Click(object sender, EventArgs e)
        {
            //TimeConsumingMethodDelegate del = new TimeConsumingMethodDelegate(TimeConsumingMethod);
            //del.BeginInvoke(Int32.Parse(textBox.Text), null, null); // ���������� ������

            TimeConsumingMethodDelegate del = TimeConsumingMethod;
            await Task.Run(()=>del(Int32.Parse(textBox.Text)));
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Cancel = true;
        }
    }
}