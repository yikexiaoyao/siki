using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _032_编程
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] strArr = str.Split(' ');
            int[] intArr = new int[strArr.Length];
            for (int i = 0; i < strArr.Length; i++)
            {
                int num = Convert.ToInt32(strArr[i]);
                intArr[i] = num;
            }
            int x = Convert.ToInt32(Console.ReadLine());
            int index = intArr.Length - 1;
            //不遍历最后一个数据
            for (int i = 0; i < intArr.Length - 1; i++)
            {
                if (x >= intArr[i] && x <= intArr[i + 1])
                {
                    index = i;
                    break;
                }
            }
            if (x < intArr[0])
            {
                index = -1;
            }
            int[] intArrNew = new int[intArr.Length + 1];
            //0~index
            for (int i = 0; i < index + 1; i++)
            {
                intArrNew[i] = intArr[i];
            }
            intArrNew[index + 1] = x;
            //m+1~length-1
            for (int i = index + 1; i < intArr.Length; i++)
            {
                intArrNew[i + 1] = intArr[i];
            }
            foreach (int temp in intArrNew)
            {
                Console.Write(temp + " ");
            }

            Console.ReadKey();
        }
    }
}
