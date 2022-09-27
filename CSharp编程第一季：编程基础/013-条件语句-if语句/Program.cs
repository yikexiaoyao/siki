using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_条件语句_if语句
{
    class Program
    {
        static void Main(string[] args)
        {
            //int age = Convert.ToInt32(Console.ReadLine());
            //if (age <= 16)
            //{
            //    Console.WriteLine("可以进入");
            //}
            //else
            //{
            //    Console.WriteLine("年龄太大，不可以进入");
            //}
            //Console.WriteLine("程序结束");

            //int num = Convert.ToInt32(Console.ReadLine());
            //if (num%2==1)
            //{
            //    Console.WriteLine("奇数");
            //}
            //else
            //{
            //    Console.WriteLine("偶数");
            //}

            //int age = Convert.ToInt32(Console.ReadLine());
            //if (age >= 18 && age <= 30)
            //{
            //    Console.WriteLine("可以参加活动");
            //    if (age % 2 == 1)
            //    {
            //        Console.WriteLine("获得奖品");
            //    }
            //    else
            //    {
            //        Console.WriteLine("没有获得奖品");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("不可以参加活动");
            //}

            //int score = Convert.ToInt32(Console.ReadLine());
            //if (score >= 90)
            //{
            //    Console.WriteLine("A");
            //}
            //else if (score >= 70)
            //{
            //    Console.WriteLine("B");
            //}
            //else if (score >= 60)
            //{
            //    Console.WriteLine("C");
            //}
            //else
            //{
            //    Console.WriteLine("D");
            //}

            //int x = Convert.ToInt32(Console.ReadLine());
            //int y = Convert.ToInt32(Console.ReadLine());
            //if (x > 0 && y > 0)
            //{
            //    Console.WriteLine("位于第一象限");
            //}
            //else if (x < 0 && y > 0)
            //{
            //    Console.WriteLine("位于第二象限");
            //}
            //else if (x > 0 && y < 0)
            //{
            //    Console.WriteLine("位于第三象限");
            //}
            //else if (x < 0 && y < 0) {
            //    Console.WriteLine("位于第四象限");
            //}
            //else if (0 == x && y != 0)
            //{
            //    Console.WriteLine("位于Y轴");
            //}
            //else if (0 == y && x != 0)
            //{
            //    Console.WriteLine("位于X轴");
            //}
            //else
            //{
            //    Console.WriteLine("位于原点");
            //}

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("可以组成三角形");
            }
            else
            {
                Console.WriteLine("不可以组成三角形");
            }

            Console.ReadKey();
        }
    }
}
