using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ITMO.DesktopCSharp.WinForms.Lab08.Ex01
{
    [Serializable, XmlRoot(Namespace = "http://www.MyCompany.com")]
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        /*
        [NonSerialized]
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        */
        [XmlIgnore]
        public int Age { get; set; }


        public override string ToString()
        {
            return LastName + " " + FirstName + "\nВозраст: " + Age + "\n";
        }

    }
}
