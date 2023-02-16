using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.DesktopCSharp.WinForms.Lab03.Ex04.RegisterForm
{
    public partial class infoForm : Form
    {
        public string RichTextBox 
        { 
            set { infoRichTextBox.Text = value; }
        }


        public infoForm()
        {
            InitializeComponent();
        }

        public infoForm(List<Person> item)
        {
            InitializeComponent();

            StringBuilder s = new StringBuilder();
            foreach (Person person in item)
            {
                s.Append($"Логин: {person.login}, PIN: {person.pin}\n");
            }
            RichTextBox= s.ToString();
        }
    }
}
