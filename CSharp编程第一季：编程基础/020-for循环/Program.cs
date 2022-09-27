using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_for循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i < 11; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine("*");
            //}

            //int sum = 0;
            //for (int i = 1; i < 101; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);

            //for (int i = 1; i < 101; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int n = Convert.ToInt32(Console.ReadLine());
            //int m = Convert.ToInt32(Console.ReadLine());

            //int sum = 0;
            //for (int i = n; i <= m; i++)
            //{
            //    if (i % 17 == 0)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine(sum);

            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());

            string ji = "";
            string ou = "";
            for (int i = n; i <= m; i++)
            {
                if (i % 2 == 1)
                {
                    ji += i + " ";
                }
                else
                {
                    ou += i + " ";
                }
            }
            Console.WriteLine(ji);
            Console.WriteLine(ou);

                Console.ReadKey();
        }
    }
}
