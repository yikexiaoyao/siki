using System;

namespace _043_方法的递归调用_练习
{
    class Program
    {
        static int F(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return F(n - 1) + n * n;
        }
        static void Main(string[] args)
        {
            //int k = 1;
            //int sum = 0;
            //while (true)
            //{
            //    sum += k * k;
            //    if (sum >= 2000)
            //    {
            //        break;
            //    }
            //    k++;
            //}
            //Console.WriteLine(k - 1);

            int k = 1;
            while (true)
            {
                if (F(k) >= 2000)
                {
                    break;
                }
                k++;
            }
            Console.WriteLine(k - 1);

            Console.ReadKey();
        }
    }
}
