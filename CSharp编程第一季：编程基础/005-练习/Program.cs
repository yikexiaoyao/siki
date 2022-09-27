using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_练习
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + b);
            Console.WriteLine("--------------------");

            double avg = (a * 1.0 + b * 1.0) / 2;
            Console.WriteLine(avg);
            Console.WriteLine("--------------------");

            Console.ReadKey();
        }
    }
}
