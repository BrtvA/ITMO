using System;

namespace ITMO.CSharpCourse.Lab03.Exercise3.WhatDay3
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
        static System.Collections.ICollection DaysInLeapMonths
            = new int[12] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please enter the year: ");
                string line = Console.ReadLine();
                int yearNum = int.Parse(line);

                bool isLeapYear = (yearNum % 4 == 0) && (yearNum % 100 != 0 || yearNum % 400 == 0);
                int maxDayNum = isLeapYear ? 366 : 365;

                Console.Write("Please enter a day number between 1 and {0}: ", maxDayNum);
                line = Console.ReadLine();
                int dayNum = int.Parse(line);

                if (dayNum < 1 || dayNum > maxDayNum)
                {
                    throw new ArgumentOutOfRangeException("Day out of range");
                }

                int monthNum = 0;

                if (isLeapYear)
                {
                    foreach (int daysInMonths in DaysInLeapMonths)
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
                }
                else
                {
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
                }

                MonthName temp = (MonthName)monthNum;
                string monthName = temp.ToString();

                Console.WriteLine("{0} {1}", dayNum, monthName);
            }
            catch (ArgumentOutOfRangeException caught)
            {
                Console.WriteLine(caught.Message);
            }
            Console.ReadKey();
        }
    }
}