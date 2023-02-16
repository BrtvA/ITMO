using ITMO.DesktopCSharp.WinForms.Lab02.Ex09.Bibl;
using System.Text;
using System.Windows.Forms;

namespace ITMO.DesktopCSharp.WinForms.Lab02.Ex09
{
    public partial class Form1 : Form
    {
        #region Книги
        public string Author // автор
        {
            get { return authorTextBox.Text; }
            set { authorTextBox.Text = value; }
        }
        public string Title // Название
        {
            get { return titleTextBox.Text; }
            set { titleTextBox.Text = value; }
        }

        public string PublishHouse // Издательство
        {
            get { return publishingTextBox.Text; }
            set { publishingTextBox.Text = value; }
        }

        public int Page // Количество страниц
        {
            get { return (int)numberPagesNumericUpDown.Value; }
            set { numberPagesNumericUpDown.Value = value; }
        }
        public int Year // Год издания
        {
            get { return (int)yearNumericUpDown.Value; }
            set { yearNumericUpDown.Value = value; }
        }
        public int InvNumber // Инвентарный номер
        {
            get { return (int)inventoryNumericUpDown.Value; }
            set { inventoryNumericUpDown.Value = value; }
        }

        public int PeriodUse // Срок пользования
        {
            get { return (int)periodNumericUpDown.Value; }
            set { periodNumericUpDown.Value = value; }
        }

        public bool Existence // Наличие
        {
            get { return availabilityCheckBox.Checked; }
            set { availabilityCheckBox.Checked = value; }
        }
        public bool ReturnTime // Возвращение в срок
        {
            get { return backCheckBox.Checked; }
            set { backCheckBox.Checked = value; }
        }

        #endregion

        //////////////////////////////////

        #region Журналы

        public string VolumeMag // Том
        {
            get { return Convert.ToString(volumeMagNumericUpDown.Value); }
            set { volumeMagNumericUpDown.Value = Convert.ToDecimal(value);}
        }

        public int NumberMag // Номер
        {
            get { return (int)numberMagNumericUpDown.Value; }
            set { numberMagNumericUpDown.Value = value;}
        }

        public string TitleMag // Название
        {
            get { return titleMagTextBox.Text; }
            set { titleMagTextBox.Text = value; }
        }

        public int YearMag // Дата выпуска
        {
            get { return (int)yearMagNumericUpDown.Value; }
            set { yearMagNumericUpDown.Value = (decimal)value; }
        }

        public int InvNumberMag // Инвентарный номер
        {
            get { return (int)inventoryMagNumericUpDown.Value; }
            set { inventoryMagNumericUpDown.Value = (decimal)(value);}
        }

        public bool ExistenceMag // Наличие
        {
            get { return availabilityMagCheckBox.Checked; }
            set { availabilityMagCheckBox.Checked = value; }
        }

        public bool SubMag // Подписка
        {
            get { return subMagCheckBox.Checked; }
            set { subMagCheckBox.Checked = value;}
        }

        #endregion

        public bool SortInvNumber // Сортировка по инвентарному номеру
        {
            get { return sortCheckBox.Checked; }
            set { sortCheckBox.Checked = value; }
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

        private void addMagBtn_Click(object sender, EventArgs e)
        {
            Magazine m = new Magazine(VolumeMag, NumberMag, TitleMag,
                                      YearMag, InvNumberMag, ExistenceMag);

            if (SubMag)
                m.Subs();

            its.Add(m);

            VolumeMag = "1";
            TitleMag = "";
            NumberMag = InvNumberMag = 1;
            ExistenceMag = SubMag = false;
        }
    }
}