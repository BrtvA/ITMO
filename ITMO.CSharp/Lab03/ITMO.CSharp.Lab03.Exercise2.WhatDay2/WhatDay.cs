using System;

namespace ITMO.CSharpCourse.Lab03.Exercise2.WhatDay2
{
    enum MonthName
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }

    class WhatDay
    {
        static System.Collections.ICollection DaysInMonths
           = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please enter a day number between 1 and 365: ");
                string line = Console.ReadLine();
                int dayNum = int.Parse(line);

                if (dayNum < 1 || dayNum > 365)
                {
                    throw new ArgumentException("Day out of range");
                }

                int monthNum = 0;

                foreach (int daysInMonths in DaysInMonths)
                {
                    if (dayNum <= daysInMonths)
                    {
                        break;
                    }
                    else
                    {
                        dayNum -= daysInMonths;
                        monthNum++;
                    }
                }

                MonthName temp = (MonthName)monthNum;
                string monthName = temp.ToString();

                Console.WriteLine("{0} {1}", dayNum, monthName);
            }
            catch (ArgumentException caught)
            {
                Console.WriteLine(caught.Message);
            }
            Console.ReadKey();
        }
    }
}