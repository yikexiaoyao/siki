using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_编程
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());
            //int temp;

            //if (a > b)
            //{
            //    temp = a;
            //    a = b;
            //    b = temp;
            //}
            //if (b > c)
            //{
            //    temp = b;
            //    b = c;
            //    c = temp;
            //}
            //if (a > b)
            //{
            //    temp = a;
            //    a = b;
            //    b = temp;
            //}
            //Console.WriteLine(a + " " + b + " " + c);

            double m = Convert.ToDouble(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());

            if (k == 0)
            {
                int temp = (int)m;
                Console.WriteLine(temp);
            }
            else if (k ==1)
            {
                double temp = (int)((m + 0.05) * 10) / 10.0;
                Console.WriteLine(temp);
            }

            Console.ReadKey();
        }
    }
}
