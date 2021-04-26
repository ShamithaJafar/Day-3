using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program
    {
        void sum()
        
            {
                Console.WriteLine("I am empty");

            }
        void sum(int a, int b)
        {
            Console.WriteLine("sum is" + (a + b));
        }

        void sum (double a, double b)
            {
            Console.WriteLine("sum is " + (a + b));
            }
        void sum(string a, string b)
        {
            Console.WriteLine("string is " + a + "  "  + b);
        }
        
        static void Main(string[] args)
        {
            Program program = new Program ();
            program.sum();
            program.sum(3,7);
            program.sum(1.5, 7.9);
            program.sum("shamitha", "Jafar");
            Console.ReadLine();
        }
    }
}
