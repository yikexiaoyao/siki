using System;

namespace _007_Func委托
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //指向有返回值方法
            Func<string> f1 = Test1;
            Console.WriteLine(f1());

            Func<int, double, string> f2 = Test2;
            Console.WriteLine(f2(3, 4));
        }

        private static string Test1()
        {
            return "siki";
        }

        private static string Test2(int x, double y)
        {
            return "siki" + x + y;
        }
    }
}