using System;

namespace ITMO.CSharp.Lab01.Exercise1.Greetings
{
    internal class Greeter
    {
        static void Main(string[] args)
        {
            string myName;

            Console.WriteLine("Please enter your name");
            myName = Console.ReadLine();
            Console.WriteLine("Hello {0}", myName);

            Console.ReadKey();
        }
    }
}
