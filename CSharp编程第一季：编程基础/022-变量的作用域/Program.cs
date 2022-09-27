using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022_变量的作用域
{
    class Program
    {
        static void Main(string[] args)
        {
            //局部
            int a = 10;

            Console.WriteLine(a);

            if (true)
            {
                int b = 20;
                Console.WriteLine(a);
                Console.WriteLine(b);
                if (true)
                {
                    int c = 30;
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                }
            }
            //Console.WriteLine(b);
            //Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
