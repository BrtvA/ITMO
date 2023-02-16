using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ITMO.DesktopCSharp.WinForms.Lab03.Ex04.LibControl2
{
    public partial class RegisterBox : UserControl
    {
        /// <summary>
        /// Название поля ввода
        /// </summary>
        [Category("MyParam"), Description("Название типа элемента управления")]
        public string TextTitle
        {
            get { return label.Text; }
            set { label.Text = value; }
        }

        /// <summary>
        /// Поле ввода
        /// </summary>
        [Category("MyParam"), Description("Текст, свяpанный с текстовым полем")]
        public string TextField
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }

        /// <summary>
        /// Что разрешено вводить в поле ввода: true - только цифры, false - цифры и буквы
        /// </summary>
        [Category("MyParam"), Description("Что разрешено вводить в текстовое поле: true - только цифры, false - цифры и буквы"),
            DefaultValue(false)]
        public bool JustNumber { get; set; }

        public RegisterBox()
        {
            InitializeComponent();
        }

        private void loginTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (TextField == "")
            {
                e.Cancel = false;
                errorProvider.SetError(textBox, null);
            }
            else
            {
                if (JustNumber)
                {
                    try
                    {
                        double.Parse(TextField);
                        if (TextField.Length != 4)
                        {
                            e.Cancel = true;
                            errorProvider.SetError(textBox, "Длина PIN должна составлять 4 символа ");
                        }
                        else
                        {
                            e.Cancel = false;
                            errorProvider.SetError(textBox, null);
                        }
                    }
                    catch
                    {
                        e.Cancel = true;
                        errorProvider.SetError(textBox, "Разрешён ввод только цифр");
                    }
                }
                else
                {
                    if (!textBox.Text.All(char.IsLetterOrDigit))
                    {
                        e.Cancel = true;
                        errorProvider.SetError(textBox, "Разрешён ввод только буквенно-цифровых символов");
                    }
                    else
                    {
                        e.Cancel = false;
                        errorProvider.SetError(textBox, null);
                    }
                }
            }
        }

        public void SwitchOnError(string message)
        {
            errorProvider.SetError(textBox, message);
        }
    }
}
