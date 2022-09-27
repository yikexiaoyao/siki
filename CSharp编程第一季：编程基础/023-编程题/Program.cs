using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_编程
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = Convert.ToInt32(Console.ReadLine());
            //int sum = n;
            //while (n != 0)
            //{
            //    n = Convert.ToInt32(Console.ReadLine());
            //    sum += n;
            //}
            //Console.WriteLine(sum);

            //int n = 0;
            //int sum = 0;
            //do
            //{
            //    n = Convert.ToInt32(Console.ReadLine());
            //    sum += n;
            //} while (n != 0);
            //Console.WriteLine(sum);

            //int n = Convert.ToInt32(Console.ReadLine());

            //double height = n;

            //for (int i = 0; i < 10; i++)
            //{
            //    height /= 2;
            //}
            //Console.WriteLine("第 10 次落地后反弹的高度是:{0}", height);

            //double distance = 2 * n;
            //double sum = n;
            //for (int i = 0; i < 10; i++)
            //{
            //    distance /= 2;
            //    sum += distance;
            //}
            //Console.WriteLine("第 10 次落地后经过了{0}米", sum);

            //int a = Convert.ToInt32(Console.ReadLine());
            //int n = Convert.ToInt32(Console.ReadLine());

            //int result = 1;

            //for (int i = 0; i < n; i++)
            //{
            //    result *= a;
            //}
            //Console.WriteLine(result);

            //int n = Convert.ToInt32(Console.ReadLine());
            //int result = 1;

            //for (int i = 1; i <= n; i++)
            //{
            //    result *= i;
            //}
            //Console.WriteLine(result);

            //int q = Convert.ToInt32(Console.ReadLine());
            //int n = Convert.ToInt32(Console.ReadLine());
            //int result = 1;
            //int sum = 1;

            //for (int i = 1; i <= n; i++)
            //{
            //    result *= q;
            //    sum += result;
            //}
            //Console.WriteLine(sum);

            //int k = Convert.ToInt32(Console.ReadLine());
            //double sn = 0;
            //int n = 0;
            //while (sn <= k)
            //{
            //    n++;
            //    sn += 1.0 / n;
            //}
            //Console.WriteLine(n);

            //double x = Convert.ToDouble(Console.ReadLine());
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    x *= 1.001;
            //}
            //Console.WriteLine(x);

            //double r = Convert.ToDouble(Console.ReadLine());
            //double m = Convert.ToDouble(Console.ReadLine());
            //int y = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < y; i++)
            //{
            //    m *= (1 + r / 100.0);
            //}
            //Console.WriteLine(m);

            //for (int i = 100; i <= 999; i++)
            //{
            //    int ge = i % 10;
            //    int shi = (i / 10) % 10;
            //    int bai = (i / 100) % 10;
            //    if (i == ge * ge * ge + shi * shi * shi + bai * bai * bai)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int n = Convert.ToInt32(Console.ReadLine());
            //while (n != 0)
            //{
            //    int i = n % 10;
            //    Console.WriteLine(i);
            //    n /= 10;
            //}

            //int n = Convert.ToInt32(Console.ReadLine());

            //int result = 0;
            //int cheng = 1;
            //while (n != 0)
            //{
            //    int i = n % 10;

            //    if (i != 0)
            //    {
            //        i *= cheng;
            //        result += i;
            //        cheng *= 10;
            //    }

            //    n /= 10;
            //}
            //Console.WriteLine(result);

            //int n = Convert.ToInt32(Console.ReadLine());
            //while (n != 0)
            //{
            //    int i = n % 10;
            //    if (i != 0)
            //    {
            //        Console.Write(i);
            //    }
            //    n /= 10;
            //}

            //int n = Convert.ToInt32(Console.ReadLine());
            //bool diyigefei0 = false;
            //while (n != 0)
            //{
            //    int i = n % 10;
            //    if (diyigefei0 == false) {  //  有没有遇到第一个非0
            //        if (i != 0)
            //        {
            //            Console.Write(i);
            //            diyigefei0 = true;
            //        }
            //    }
            //    else
            //    {
            //        Console.Write(i);
            //    }
            //    n /= 10;
            //}

            int n = Convert.ToInt32(Console.ReadLine());
            int tempN = n;
            int num = 0;
            while (tempN != 0)
            {
                int i = tempN % 10;
                num *= 10;
                num += i;
                tempN /= 10;
            }
            if (num == n)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

            Console.ReadKey();
        }
    }
}
