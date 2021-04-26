using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Class9
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a String : ");
            string String1 = Console.ReadLine();
            string result = string.Empty;
            int l = String1.Length;
            for (int i = 0; i < l; i++)
            {
                if (!result.Contains(String1[i]))
                {
                    result += String1[i];
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
