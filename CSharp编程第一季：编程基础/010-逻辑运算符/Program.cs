using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_逻辑运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = (3 < 4) && (9 < 6);
            bool b = (3 < 4) || (9 < 6);
            bool c = !(4 < 7);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine("--------------------");

            int age = Convert.ToInt32(Console.ReadLine());
            bool isYoung = age >= 18 && age <= 60;
            Console.WriteLine(isYoung);
            Console.WriteLine("--------------------");

            Console.ReadKey();
        }
    }
}
