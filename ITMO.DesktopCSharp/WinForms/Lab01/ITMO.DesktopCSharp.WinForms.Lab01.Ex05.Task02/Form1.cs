namespace ITMO.DesktopCSharp.WinForms.Lab01.Ex05.Task02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            closeBtn.Left = this.ClientSize.Width / 2 - closeBtn.Width / 2;
            closeBtn.Top = this.ClientSize.Height / 2 - closeBtn.Height / 2;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath =
               new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddPolygon(new Point[] {
                new Point(0, this.Height/2),
                new Point(this.Width/2, 0),
                new Point(this.Width, this.Height/2),
                new Point(this.Width/2, this.Height) });
            Region myRegion = new Region(myPath);
            this.Region = myRegion;
        }
    }
}