using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_switch分支语句
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = Convert.ToInt32(Console.ReadLine());
            //switch (num)
            //{
            //    case 1:
            //        Console.WriteLine("矿泉水");
            //        break;
            //    case 2:
            //        Console.WriteLine("红茶");
            //        break;
            //    case 3:
            //        Console.WriteLine("绿茶");
            //        break;
            //    case 4:
            //        Console.WriteLine("雪碧");
            //        break;
            //    case 5:
            //        Console.WriteLine("可口可乐");
            //        break;
            //    case 6:
            //        Console.WriteLine("脉动");
            //        break;
            //    default:
            //        Console.WriteLine("没有你要购买的商品");
            //        break;
            //}

            int week = Convert.ToInt32(Console.ReadLine());
            switch (week)
            {
                case 1:
                case 2:
                    Console.WriteLine("Arduino");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("C++");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Scratch");
                    break;

            }

            Console.ReadKey();
        }
    }
}
