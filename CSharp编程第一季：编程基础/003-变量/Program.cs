using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_变量
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建变量
            int a = 1;
            a = 3 + 7 - 2;

            int b = 3;
            b = b + 1;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("--------------------");

            int c;
            c = 10;//初始化
            c = 11;
            Console.WriteLine(c);
            Console.WriteLine("--------------------");

            char sex = 'f';
            sex = 'm';
            Console.WriteLine(sex);
            Console.WriteLine("--------------------");

            a = 3;
            b = 8;
            Console.WriteLine(a + b);
            Console.WriteLine("a + b");
            Console.WriteLine(a + "+" + b);
            Console.WriteLine("a+b" + a + b);
            Console.WriteLine("a+b" + (a + b));
            Console.WriteLine("--------------------");

            Console.ReadKey();
        }
    }
}
