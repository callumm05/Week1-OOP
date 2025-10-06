using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Week1
{
    internal class Task4
    {
        public static void Week1_Task4()
        {
            Console.WriteLine("Enter a year.");
            int year = Int32.Parse(Console.ReadLine());

            if (year<0)
            {
                Console.WriteLine("This is not a valid year.\n");
            }
            else
            {
                if ((year % 4 == 0 && year % 100 != 0))
                {
                    Console.WriteLine($"{year} is a leap year\n");
                }
                else
                {
                    Console.WriteLine($"{year} is not a leap year\n");
                }
            }
        }
    }
}
