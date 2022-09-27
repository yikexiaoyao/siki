using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_编程
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = Convert.ToInt32(Console.ReadLine());
            //int ge = num % 10;
            //int shi = (num / 10) % 10;
            //int bai = num / 100;
            //Console.WriteLine("" + ge + shi + bai);

            //int num = Convert.ToInt32(Console.ReadLine());
            //int shi = (num / 10) % 10;
            //int qian = (num / 1000) % 10;
            //int numNew = qian * 10 + shi;
            //char c = (char)numNew;
            //Console.WriteLine(c);

            int a = 3;
            int b = a++ + a++;
            Console.WriteLine(b);
            Console.WriteLine(a);

            a = 3;
            b = a++ + ++a;
            Console.WriteLine(b);
            Console.WriteLine(a);

            int mathScore = Convert.ToInt32(Console.ReadLine());
            int englishScore = Convert.ToInt32(Console.ReadLine());
            bool isGetAward = mathScore >= 90 && englishScore >= 90;
            Console.WriteLine(isGetAward);

            Console.ReadKey();
        }
    }
}
