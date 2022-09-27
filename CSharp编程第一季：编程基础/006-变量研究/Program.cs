using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_变量研究
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 10;

            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("--------------------");

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("--------------------");

            a = 23;
            b = 45;
            Console.WriteLine(a + "+" + b + "=" + (a + b));
            Console.WriteLine("{0}+{1}={2}", a, b, a+b);
            Console.WriteLine("--------------------");

            Console.WriteLine("两个数字相加{0}+{0}={2}", 34, 123, 4);
            Console.WriteLine("--------------------");

            Console.ReadKey();
        }
    }
}
