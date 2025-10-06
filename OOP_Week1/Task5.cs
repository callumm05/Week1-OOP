using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Week1
{
    internal class Task5
    {
        public static void Week1_Task5()
        {
            Console.WriteLine("Enter a number.");
            int num = Int32.Parse(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine("This number is not even or odd.\n");
            }
            else
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("This number is even.\n");
                }
                else
                {
                    Console.WriteLine("This number is odd.\n");
                }
            }
        }
    }
}
