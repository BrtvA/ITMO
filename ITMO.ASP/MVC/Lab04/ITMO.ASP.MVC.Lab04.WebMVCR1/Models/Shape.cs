using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITMO.ASP.MVC.Lab04.WebMVCR1.Models
{
    public class Shape
    {
        public double St { get; set; }
        virtual public string Name => String.Format("\"Фигура\"");
    }

    public class Triangle : Shape, IComparable<Triangle>
    {
        public double Stb { get; set; }
        public double Stc { get; set; }

        public override string Name => $"\"Треугольник со сторонами {St}, {Stb} и {Stc}\"";
        public double Perimeter => Math.Round(St + Stb + Stc);
        public double Area => Math.Sqrt(Perimeter / 2 * (Perimeter / 2 - St)
                           * (Perimeter / 2 - Stb) * (Perimeter / 2 - Stc));

        public Triangle(double a, double b, double c)
        {
            St = a;
            Stb = b;
            Stc = c;
        }

        public int CompareTo(Triangle other)
        {
            if (this.Perimeter == other.Perimeter) return 0;
            else if (this.Perimeter > other.Perimeter) return 1;
            else return -1;
        }
    }

    public class Circle : Shape, IComparable<Circle>
    {
        public override string Name => String.Format("\"Окружность с радиусом {0}\"", St);
        public double Dlina => 2 * Math.PI * St;
        public double Area => Math.PI * St * St;

        public Circle(double a)
        {
            St = a;
        }

        public int CompareTo(Circle other)
        {
            if (this.Area == other.Area) return 0;
            else if (this.Area > other.Area) return 1;
            else return -1;
        }
    }
}