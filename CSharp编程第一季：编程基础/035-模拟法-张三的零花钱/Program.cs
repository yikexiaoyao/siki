using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _035_模拟法_张三的零花钱
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] strArr = str.Split(' ');
            int[] bueget = new int[strArr.Length];
            for (int i = 0; i < strArr.Length; i++)
            {
                int num = Convert.ToInt32(strArr[i]);
                bueget[i] = num;
            }
            //自己留着
            double self = 0;
            //存到妈妈那里
            double mom = 0;
            //超出预算的月份-1
            int yue = 0;
            //花完预算还剩多少
            double left = 0;
            //遍历每个月
            for (yue = 0; yue < 12; yue++)
            {
                left = 300 + self - bueget[yue];
                //超出预算
                if (left < 0)
                {
                    break;
                }
                //整百存到妈妈那里
                mom += (left / 100) * 100;
                //当月自己还剩多少
                self = left % 100;
            }
            //超出预算
            if (left < 0)
            {
                Console.WriteLine("-" + (yue + 1));
            }
            else
            {
                //总共还有多少钱
                self = self + mom * 1.2;
                Console.WriteLine(self);
            }

            Console.ReadKey();
        }
    }
}
