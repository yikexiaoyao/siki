using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _037_真素数
{
    class Program
    {
        static bool IsSu(int num)
        {
            bool isSu = true;
            for (int i = 2; i < num - 1; i++)
            {
                if (num % i == 0)
                {
                    isSu = false;
                    break;
                }
            }
            return isSu;
        }
        static void Main(string[] args)
        {
            //m<=n
            string str = Console.ReadLine();
            string[] strArr = str.Split(' ');
            int[] intArr = new int[strArr.Length];
            for (int i = 0; i < strArr.Length; i++)
            {
                int num = Convert.ToInt32(strArr[i]);
                intArr[i] = num;
            }
            int m = intArr[0];
            int n = intArr[1];

            for (int i = m; i < n + 1; i++)
            {
                bool isSu = IsSu(i);
                //判断是否为素数
                if (isSu)
                {
                    int temp = i;
                    int num = 0;
                    //取得反序
                    while (temp % 10 != 0)
                    {
                        num = num * 10 + temp % 10;
                        temp = temp / 10;
                    }
                    bool isSuFan = IsSu(num);
                    //判断是否为素数
                    if (isSuFan == true)
                    {
                        Console.Write(i + " ");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
