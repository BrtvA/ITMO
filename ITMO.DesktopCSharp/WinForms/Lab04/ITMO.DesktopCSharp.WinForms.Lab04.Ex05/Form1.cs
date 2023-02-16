namespace ITMO.DesktopCSharp.WinForms.Lab04.Ex05
{
    public partial class Form1 : Form
    {
        public string PointData
        {
            get
            { return richTextBox1.Text; }
            set
            { richTextBox1.Text = value; }
        }

        public string Interval
        {
            get { return intervalLabel.Text; }
            set { intervalLabel.Text = value; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void setIntervalBtn_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.StartPosition = FormStartPosition.Manual;
            frm2.Location = new Point(this.Location.X + this.Width, this.Location.Y);
            frm2.Show(this);
        }
    }
}