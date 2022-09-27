using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_while循环_编程
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = Convert.ToInt32(Console.ReadLine());
            //int i = 0;
            //while (n != 1)
            //{
            //    if (n % 2 == 1)
            //    {
            //        n = 3 * n + 1;
            //    }
            //    else
            //    {
            //        n /= 2;
            //    }
            //    i++;
            //    Console.WriteLine("变换后的值为" + n);
            //}
            //Console.WriteLine("变换的次数为" + i);

            //int num = 80000;
            //int year = 2006;
            //while (num < 200000)
            //{
            //    num = (int)(num * 1.25);
            //    year++;
            //}

            //Console.WriteLine(year);

            //int n = Convert.ToInt32(Console.ReadLine());
            //int i = 1;
            //int sum = 0;
            //while (i <= n)
            //{
            //    //int age = Convert.ToInt32(Console.ReadLine());
            //    //sum += age;
            //    sum += Convert.ToInt32(Console.ReadLine());
            //    i++;
            //}
            //double avg = sum * 1.0 / n;
            //avg = ((int)(avg * 100)) / 100.0;
            //Console.WriteLine(avg);

            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i <= n)
            {
                Console.Write(i + " ");
                i++;
            }

            Console.ReadKey();
        }
    }
}
