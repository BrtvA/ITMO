using System;

namespace ITMO.CSharp.Lab09.Exercise1.ColorTokeniser
{
    public class Application
    {
        public static void Main(string[] args)
        {
            try
            {
                InnerMain(args);
            }
            catch (System.Exception caught)
            {
                Console.WriteLine(caught);
            }

            Console.ReadKey();
        }

        public static void InnerMain(string[] args)
        {
            SourceFile source = new SourceFile(args[0]);
            HTMLTokenVisitor visitor = new HTMLTokenVisitor();

            source.Accept(visitor);
        }
    }
}
