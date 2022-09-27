using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_编程
{
    class Program
    {
        static void Main(string[] args)
        {
            //int year = Convert.ToInt32(Console.ReadLine());
            //if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            //{
            //    Console.WriteLine("是闰年");
            //}
            //else
            //{
            //    Console.WriteLine("不是闰年");
            //}

            //int num = Convert.ToInt32(Console.ReadLine());
            //if (num < 0)
            //{
            //    Console.WriteLine(0-num);
            //}
            //else
            //{
            //    Console.WriteLine(num);
            //}

            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());
            //int max = a;
            //if (b > max)
            //{
            //    max = b;
            //}
            //if (c > max)
            //{
            //    max = c;
            //}
            //Console.WriteLine(max * max);

            //char a = Convert.ToChar(Console.ReadLine());
            //char b = Convert.ToChar(Console.ReadLine());
            //if (a > b)
            //{
            //    Console.WriteLine("{0}>{1}", a, b);
            //}
            //else
            //{
            //    Console.WriteLine("{0}<{1}", a, b);
            //}

            char sex = Convert.ToChar(Console.ReadLine());
            int num = Convert.ToInt32(Console.ReadLine());
            string project;
            if (sex == 'F')
            {
                //Console.WriteLine("800m长跑");
                project = "800m长跑";
                if (num % 2 == 1)
                {
                    //Console.WriteLine("跳绳");
                    project += "、跳绳";
                }
                else
                {
                    //Console.WriteLine("仰卧起坐");
                    project += "、仰卧起坐";
                }
                Console.WriteLine(project);
            }
            else
            {
                //Console.WriteLine("1000m长跑");
                project = "1000m长跑";
                if (num % 2 == 1)
                {
                    //Console.WriteLine("跳远");
                    project += "、跳远";
                }
                else
                {
                    //Console.WriteLine("俯卧撑");
                    project += "、俯卧撑";
                }
                Console.WriteLine(project);
            }

            Console.ReadKey();
        }
    }
}
