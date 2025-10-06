using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Week1
{
    internal class Task2
    {
        public static void Week1_Task2()
        {
            Console.WriteLine("Enter your age.");
            int age = Int32.Parse(Console.ReadLine());

            if (age<13)
            {
                Console.WriteLine("Child\n");
            }
            else if(age>=13 && age<=19)
            {
                Console.WriteLine("Teenager\n");
            }
            else if(age>19 && age<110)
            {
                Console.WriteLine("Adult\n");
            }
            else
            {
                Console.WriteLine("Your age is invalid.\n");
            }
        } 
    }
}
