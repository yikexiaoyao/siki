using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _026_循环嵌套
{
    class Program
    {
        static void Main(string[] args)
        {
            ////行
            //for (int i = 0; i < 4; i++)
            //{
            //    //列
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //int n = Convert.ToInt32(Console.ReadLine());
            //int m = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i < n + 1; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i < n + 1; i++)
            //{
            //    for (int j = 0; j < i - 1; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine("*");
            //}

            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = n; i > 0; i--)
            //{
            //    for (int j = 0; j < i - 1; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine("*");
            //}

            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i < n + 1; i++)
            //{
            //    //每行输出 (行号-1) 个空格
            //    for (int j = 0; j < i - 1; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    //每行输出n个*
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    //换行
            //    Console.WriteLine();
            //}

            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i < n + 1; i++)
            //{
            //    //每行输出 (n-行号) 个空格
            //    for (int j = 0; j < n - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    //每行输出行号个*
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    //换行
            //    Console.WriteLine();
            //}

            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i < n + 1; i++)
            //{
            //    //每行输出 (n-行号) 个空格
            //    for (int j = 0; j < n - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    //每行输出 (2*行号-1) 个*
            //    for (int j = 0; j < 2 * i - 1; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    //换行
            //    Console.WriteLine();
            //}

            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i < n; i++)
            //{
            //    //每行输出 (n-行号) 个空格
            //    for (int j = 0; j < n - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    //每行输出 (2*行号-1) 个*
            //    for (int j = 0; j < 2 * i - 1; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    //换行
            //    Console.WriteLine();
            //}
            ////n-1行
            //for (int i = 0; i < n; i++)
            //{
            //    //每行输出行号个空格                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                行号个空格
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    //每行输出 2*(n-行号)-1 个*
            //    for (int j = 0; j < 2 * (n - i) - 1; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    //换行
            //    Console.WriteLine();
            //}

            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("{0} x {1} = {2}  ", j, i, i * j);
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 1; i <= 100 / 3; i++)
            //{
            //    for (int j = 1; j <= 100 / 5; j++)
            //    {
            //        for (int k = 1; k <= 100 / 2; k++)
            //        {
            //            if (3 * i + 5 * j + 2 * k == 100)
            //            {
            //                Console.WriteLine("公鸡{0}只, 母鸡{1}只, 小鸡{2}只", i, j ,k);
            //            }
            //        }
            //    }
            //}

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int min = num1;
            if (num2 < min)
            {
                min = num2;
            }
            for (int i = min; i > 0; i--)
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    Console.WriteLine("最大公约数{0}", i);
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
