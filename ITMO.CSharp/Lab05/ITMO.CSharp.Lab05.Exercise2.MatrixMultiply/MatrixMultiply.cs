using System;

namespace ITMO.CSharp.Lab05.Exercise2.MatrixMultiply
{
    public class MatrixMultiply
    {
        static void Main()
        {
            int[,] a = Input();

            int[,] b = Input();

            int[,] result = Multiply(a, b);

            Output(result);

            Console.ReadKey();
        }

        static void Output(int[,] result)
        {
            for (int r = 0; r < result.GetLength(0); r++)
            {
                for (int c = 0; c < result.GetLength(1); c++)
                {
                    Console.Write("{0} ", result[r, c]);
                }
                Console.WriteLine();
            }
        }

        static int[,] Multiply(int[,] a, int[,] b)
        {
            int[,] result = new int[2, 2];
            for (int r = 0; r < result.GetLength(0); r++)
            {
                for (int c = 0; c < result.GetLength(1); c++)
                {
                    result[r, c] += a[r, 0] * b[0, c] + a[r, 1] * b[1, c];
                }
            }
            return result;

        }

        static int[,] Input()
        {
            int[,] array = new int[2, 2];
            for (int r = 0; r < array.GetLength(0); r++)
            {
                for (int c = 0; c < array.GetLength(1); c++)
                {
                    Console.Write("Enter value for [{0},{1}] : ", r, c);
                    string s = Console.ReadLine();
                    array[r, c] = int.Parse(s);
                }
            }
            Console.WriteLine();
            return array;
        }
    }
}

