using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _025_循环中的continue
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
