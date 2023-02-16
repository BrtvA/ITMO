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
    public partial class Form1 : Form
    {
        infoForm infoFrm;

        public string Login
        {
            get { return loginRegisterBox.TextField; }
            set { loginRegisterBox.TextField = value;}
        }

        public int PIN
        {
            get 
            {
                if (pinRegisterBox.TextField == "")
                    return 0;
                else
                    return Convert.ToInt32(pinRegisterBox.TextField); 
            }
            set { pinRegisterBox.TextField = ""; }
        }

        List<Person> people= new List<Person>();
        public Form1()
        {
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (Login == "" && PIN == 0)
            {
                loginRegisterBox.SwitchOnError("Заполните поле");
                pinRegisterBox.SwitchOnError("Заполните поле");
                return;
            }
            if (Login == "")
            {
                loginRegisterBox.SwitchOnError("Заполните поле");
                return;
            }
            if (PIN == 0)
            {
                pinRegisterBox.SwitchOnError("Заполните поле");
                return;
            }
            foreach (var item in people)
            {
                if (item.login == Login)
                {
                    loginRegisterBox.SwitchOnError("Такой пользователь уже существует");
                    return;
                }
            }

            Person person = new Person(Login, PIN);
            people.Add(person);

            Login = "";
            PIN=0;
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            if (infoFrm != null)
            {
                infoFrm.Close();
                infoFrm.Dispose();
            }
            infoFrm = new infoForm(people);
            infoFrm.StartPosition = FormStartPosition.Manual;
            infoFrm.Location = new Point(this.Location.X + this.Width, this.Location.Y);
            infoFrm.Show();
        }
    }
}
