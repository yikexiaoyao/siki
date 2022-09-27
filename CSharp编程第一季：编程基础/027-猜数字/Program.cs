using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _027_猜数字
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int num = r.Next(1, 101);  //1~100   伪随机数
            while (true)
            {
                Console.WriteLine("猜猜我的数字是多少");
                int numUser = Convert.ToInt32(Console.ReadLine());
                if (numUser > num)
                {
                    Console.WriteLine("大了");
                }
                else if (numUser < num)
                {
                    Console.WriteLine("小了");
                }
                else
                {
                    Console.WriteLine("你猜中了");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
