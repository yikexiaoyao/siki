using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_字符类型
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = 'c';
            int b = a;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("--------------------");

            b = 97;
            a = (char)b;//强制类型转换
            Console.WriteLine(b);
            Console.WriteLine(a);
            Console.WriteLine("--------------------");

            a = '1';
            b = a;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("--------------------");

            char c = '\n';
            char d = '\\';
            char e = '\"';
            char f = '\t';
            char g = '\'';
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine("--------------------");

            Console.WriteLine(@"c:\a\b\c");
            Console.WriteLine("--------------------");

            string str = @"www.sikiedu.com\nsiki";
            Console.WriteLine(str);
            Console.WriteLine("--------------------");

            string str1 = "123" + "456";
            string str2 = str1 + "www";
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine("www" + 123);
            Console.WriteLine("--------------------");

            string input = Console.ReadLine();
            int inputInt = Convert.ToInt32(input);
            Console.WriteLine(inputInt + "-");
            Console.WriteLine("--------------------");

            Console.ReadKey();
        }
    }
}
