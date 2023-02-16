using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.DesktopCSharp.WinForms.Lab03.Ex04.RegisterForm
{
    public class Person
    {
        public string login;
        public int pin;

        public Person(string login, int pin)
        {
            this.login= login;
            this.pin= pin;
        }
    }
}
