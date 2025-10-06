using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Week1
{
    internal class Task3
    {
        public static void Week1_Task3()
        {
            Console.WriteLine("Please enter an integer");
            int num = Int32.Parse(Console.ReadLine());

            if (num>0)
            {
                Console.WriteLine("This is a positive number\n");
            }
            else if (num==0)
            {
                Console.WriteLine("The number is 0.\n");
            }
            else if(num<0)
            {
                Console.WriteLine("This is a negative number.\n");
            }
        }
    }
}
