using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_关系运算符和布尔类型
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = 45 == 67;
            bool b = 45 < 67;
            bool c = 45 <= 67;
            bool d = 45 > 67;
            bool e = 45 >= 67;
            bool f = 45 != 67;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine("--------------------");

            Console.ReadKey();
        }
    }
}
