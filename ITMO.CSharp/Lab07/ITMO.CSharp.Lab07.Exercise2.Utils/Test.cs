using System;

namespace ITMO.CSharp.Lab07.Exercise2.Utils
{
    public class Test
    {
        static void Main()
        {
            string message;

            // Get an input string
            Console.WriteLine("Enter string to reverse:");
            message = Console.ReadLine();

            // Reverse the string
            Utils.Reverse(ref message);

            // Display the result
            Console.WriteLine(message);

            Console.ReadKey();
        }
    }
}