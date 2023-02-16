using ITMO.DesktopCSharp.WinForms.Lab02.Ex06.Bibl;
using System.Text;
using System.Windows.Forms;

namespace ITMO.DesktopCSharp.WinForms.Lab02.Ex06
{
    public partial class Form1 : Form
    {
        public string Author // �����
        {
            get { return authorTextBox.Text; }
            set { authorTextBox.Text = value; }
        }
        public string Title // ��������
        {
            get { return titleTextBox.Text; }
            set { titleTextBox.Text = value; }
        }

        public string PublishHouse // ������������
        {
            get { return publishingTextBox.Text; }
            set { publishingTextBox.Text = value; }
        }

        public int Page // ���������� �������
        {
            get { return (int)numberPagesNumericUpDown.Value; }
            set { numberPagesNumericUpDown.Value = value; }
        }
        public int Year // ��� �������
        {
            get { return (int)yearNumericUpDown.Value; }
            set { yearNumericUpDown.Value = value; }
        }
        public int InvNumber // ����������� �����
        {
            get { return (int)inventoryNumericUpDown.Value; }
            set { inventoryNumericUpDown.Value = value; }
        }

        public int PeriodUse // ���� �����������
        {
            get { return (int)periodNumericUpDown.Value; }
            set { periodNumericUpDown.Value = value; }
        }

        public bool Existence // �������
        {
            get { return availabilityCheckBox.Checked; }
            set { availabilityCheckBox.Checked = value; }
        }
        public bool SortInvNumber // ���������� �� ������������ ������
        {
            get { return sortCheckBox.Checked; }
            set { sortCheckBox.Checked = value; }
        }
        public bool ReturnTime // ����������� � ����
        {
            get { return backCheckBox.Checked; }
            set { backCheckBox.Checked = value; }
        }

        List<Item> its = new List<Item>();

        public Form1()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Book b = new Book(Author, Title, PublishHouse,
                              Page, Year, InvNumber, Existence);

            if (ReturnTime)
                b.ReturnSrok();

            b.PriceBook(PeriodUse);

            its.Add(b);

            Author = Title = PublishHouse = "";
            Page = InvNumber = PeriodUse = 1;
            Year = 2020;
            Existence = ReturnTime = false;
        }

        private void watchBtn_Click(object sender, EventArgs e)
        {
            if (SortInvNumber)
                its.Sort();

            StringBuilder sb = new StringBuilder();
            foreach (Item item in its)
            {
                sb.Append("\n" + item.ToString());
            }

            richTextBox.Text = sb.ToString();
        }
    }
}