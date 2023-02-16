namespace ITMO.DesktopCSharp.WinForms.Lab07.Ex04
{
    public partial class Form1 : Form
    {
        private delegate int AsyncSumm(int a, int b);
        delegate void PrintLabel(string str);
        private PrintLabel PrintDlegateFunc;

        public Form1()
        {
            InitializeComponent();

            PrintDlegateFunc = new PrintLabel(PrintFunc);
        }

        private int Summ(int a, int b)
        {
            System.Threading.Thread.Sleep(9000);
            return a + b;
        }

        private async void btnRun_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                // �������������� ����� ������.
                a = Int32.Parse(txbA.Text);
                b = Int32.Parse(txbB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("��� ���������� �������������� ����� �������� ������");
                txbA.Text = txbB.Text = "";
                return;
            }
            AsyncSumm summdelegate = new AsyncSumm(Summ);
            //AsyncCallback cb = new AsyncCallback(CallBackMethod);
            //summdelegate.BeginInvoke(a, b, cb, summdelegate); // ���������� ����� BeginInvoke
            await Task.Run(()=>CallBackMethod(summdelegate, a, b));
        }

        private void CallBackMethod(AsyncSumm summ, int a, int b)
        {
            string str = summ(a,b).ToString();
            //MessageBox.Show(str, "��������� ��������");
            lblResult.Invoke(PrintDlegateFunc, new object[] { str });
        }

        /*
        private void CallBackMethod(IAsyncResult ar)
        {
            string str;
            AsyncSumm summdelegate = (AsyncSumm)ar.AsyncState;
            str = String.Format("����� ��������� ����� ����� {0}",
                                summdelegate.EndInvoke(ar));
            MessageBox.Show(str, "��������� ��������");
        }
        */

        void PrintFunc(string str)
        {
            lblResult.Text = str;
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            MessageBox.Show("������ �����!!!");
        }

        private async void btnDiff_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                a = Int32.Parse(txbA.Text);
                b = Int32.Parse(txbB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("��� ���������� �������������� ����� �������� ������");
                txbA.Text = txbB.Text = "";
                return;
            }
            int res = await Subb(a, b);
            lblDiffResult.Text = res.ToString();
        }

        private async Task<int> Subb(int a, int b)
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(5000);
                return a - b;
            });
        }
    }
}