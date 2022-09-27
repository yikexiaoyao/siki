using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031_编程
{
    class Program
    {
        static void Main(string[] args)
        {
            //int pingNum = 364;
            //int heleNum = 364;
            //while (pingNum > 2)
            //{
            //    heleNum += pingNum / 3;
            //    pingNum = (pingNum / 3) + (pingNum % 3);
            //}
            //Console.WriteLine("一共可以喝{0}瓶,剩下{1}个空瓶", heleNum, pingNum);

            //string str = Console.ReadLine();
            //char[] strArr = str.ToCharArray();
            //for (int i = 0; i < strArr.Length; i++)
            //{
            //    if ((strArr[i] >= 'a' && strArr[i] <= 'z') || (strArr[i] >= 'A' && strArr[i] <= 'Z'))
            //    {
            //        strArr[i] = (char)(strArr[i] + 3);
            //    }
            //    if ((strArr[i] > 'z' && strArr[i] <= 'z' + 3) || (strArr[i] > 'Z' && strArr[i] <= 'Z' + 3))
            //    {
            //        strArr[i] = (char)(strArr[i] - 26);
            //    }
            //}
            //foreach (char item in strArr)
            //{
            //    Console.Write(item);
            //}

            string str = Console.ReadLine();
            string[] strArr = str.Split(' ');
            int[] intArr = new int[strArr.Length];
            for (int i = 0; i < strArr.Length; i++)
            {
                int num = Convert.ToInt32(strArr[i]);
                intArr[i] = num;
            }
            int min = intArr[0];
            int minIndex = 0;
            for (int i = 1; i < intArr.Length; i++)
            {
                if (intArr[i] < min)
                {
                    min = intArr[i];
                    minIndex = i;
                }
            }
            int temp = intArr[0];
            intArr[0] = intArr[minIndex];
            intArr[minIndex] = temp;
            foreach (int t in intArr)
            {
                Console.Write(t + " ");
            }

            Console.ReadKey();
        }
    }
}
