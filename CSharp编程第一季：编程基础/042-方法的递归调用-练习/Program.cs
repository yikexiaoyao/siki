using System;

namespace _042_方法的递归调用_练习
{
    class Program
    {
        static int F(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n * F(n - 1);
        }
        static int Add(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return Add(n - 1) + F(n);
        }
        static void Main(string[] args)
        {
            //int result = 1;
            //for (int i = 1; i < 11; i++)
            //{
            //    result *= i;
            //}
            //Console.WriteLine(result);

            //Console.WriteLine(F(10));

            //int sum = 0;
            //for (int i = 1; i < 11; i++)
            //{
            //    //获取 i!
            //    int temp = 1;
            //    for (int j = 1; j < i + 1; j++)
            //    {
            //        temp *= j;
            //    }
            //    sum += temp;
            //}
            //Console.WriteLine(sum);

            Console.WriteLine(Add(10));

            Console.ReadKey();
        }
    }
}
