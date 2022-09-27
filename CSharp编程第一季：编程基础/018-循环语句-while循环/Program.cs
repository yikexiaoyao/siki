using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_循环语句_while循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //int i = 1;
            //while (i <= 100)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //int HP = 100;
            //while (HP > 0)
            //{
            //    HP -= 3;
            //    Console.WriteLine("HP" + HP);
            //}

            //int i = 100;
            //while (i > 0)
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}

            //int i = 1;
            //int sum = 0;
            //while (i <= 100)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);

            //int n = Convert.ToInt32(Console.ReadLine());
            //int i = 1;
            //int sum = 0;
            //while (i <= n)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);

            //int i = 1;
            //while (i <= 100)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            if (n1 <= n2)
            {
                int i = n1;
                while (i <= n2)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                    i++;
                }
            }
            else if (n1 > n2)
            {
                int i = n2;
                while (i <= n1)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                    i++;
                }
            }

            Console.ReadKey();
        }
    }
}
