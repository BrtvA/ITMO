using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace ITMO.ADO.Lab7.ex1.Linq_Student
{
    class Program
    {
        static List<Student> students = new List<Student>
        {
            new Student {First="Svetlana",
                         Last="Omelchenko",
                         ID=111, 
                         Scores= new List<int> {97, 92, 81, 60}},
            new Student {First="Claire",
                         Last="O’Donnell",
                         ID=112,
                         Scores= new List<int> {75, 84, 91, 39}},
        };

        static void Main()
        {
            IEnumerable<Student> studentQuery = 
                from student in students 
                where student.Scores[0] > 90
                select student;
            foreach (Student student in studentQuery)
            {
                Console.WriteLine("{0}, {1}", student.Last, student.First);
            }
        }
    }
}
