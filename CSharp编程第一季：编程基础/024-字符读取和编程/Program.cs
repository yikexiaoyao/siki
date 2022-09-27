using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _024_字符读取和编程
{
    class Program
    {
        static void Main(string[] args)
        {
            //char c;
            //int result = 0;
            //do
            //{
            //    c = (char)Console.Read();
            //    if (c >= '0' && c <= '9')
            //    {
            //        int num = c - '0';
            //        result += num;
            //    }
            //} while (c != '@');
            //Console.WriteLine(result);

            //char c;
            //int sum = 0;
            //do
            //{
            //    c = (char)Console.Read();
            //    if (c >= '0' && c <= '9')
            //    {
            //        int num = c - '0';
            //        sum += num;
            //    }
            //    else if (c == '*')
            //    {
            //        sum += 500;
            //    }
            //} while (c != '#');
            //Console.WriteLine(sum);

            //int n = Convert.ToInt32(Console.ReadLine());
            //int count = 0;
            //string str = "";
            //for (int i = 1; i <= n; i++)
            //{
            //    if (n % i == 0)
            //    {
            //        count++;
            //        str += i + " ";
            //    }
            //}
            //Console.WriteLine(count);
            //Console.WriteLine(str);

            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            Console.WriteLine(count);

            Console.ReadKey();
        }
    }
}
