using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Week1
{
    internal class Task1
    {
        public static void Week1_Task1()
        {
            Console.WriteLine("Please enter your name.");
            String name = (Console.ReadLine());
            Console.WriteLine("Please enter your age.");
            int age = Int32.Parse(Console.ReadLine());

            int age2 = age + 5;

            Console.WriteLine("Hello " + name + ", you will be " + age2 + " in 5 years.\n");
        }
    }
}
