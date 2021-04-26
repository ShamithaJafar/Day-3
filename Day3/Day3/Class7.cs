using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Class7
    {
        public static void Main()
        {
            String string1 = "It is a bad color";
           if (string1.Contains("is a"))
            {
                Console.WriteLine("it is present");
            }
            else
            {
                Console.WriteLine("it is absent");
            }
            Console.ReadLine();
        }
    }
}
