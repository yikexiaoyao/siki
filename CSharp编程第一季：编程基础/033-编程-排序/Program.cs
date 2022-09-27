using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _033_编程_排序
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = Console.ReadLine();
            //string[] strArr = str.Split(' ');
            //int[] intArr = new int[strArr.Length];
            //for (int i = 0; i < strArr.Length; i++)
            //{
            //    int num = Convert.ToInt32(strArr[i]);
            //    intArr[i] = num;
            //}

            ////轮数
            //for (int i = 0; i < intArr.Length - 1; i++)
            //{
            //    //比较
            //    //标识，本轮是否发生交换
            //    bool isChanged = false;
            //    for (int j = 0; j < intArr.Length - 1; j++)
            //    {
            //        //降序  如果左边大于右边，则交换
            //        if (intArr[j] > intArr[j + 1])
            //        {
            //            int temp = intArr[j];
            //            intArr[j] = intArr[j + 1];
            //            intArr[j + 1] = temp;
            //            isChanged = true;
            //        }
            //    }
            //    if (isChanged == false)
            //    {
            //        break;
            //    }
            //}
            //foreach (int item in intArr)
            //{
            //    Console.Write(item + " ");
            //}

            //string str = Console.ReadLine();
            ////判断 数字 字母 _
            ////数字开头
            //bool isRight = true;
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if ((str[i] < '0' || str[i] > '9') && (str[i] < 'a' || str[i] > 'z') && (str[i] < 'A' || str[i] > 'Z') && str[i] != '_')
            //    {
            //        isRight = false;
            //        break;
            //    }
            //}
            //if (str[0] >= '0' && str[0] <= '9')
            //{
            //    isRight = false;
            //}
            //if (isRight)
            //{
            //    Console.WriteLine("是合法标识符");
            //}
            //else
            //{
            //    Console.WriteLine("不是合法标识符");
            //}

            //string str = Console.ReadLine();
            //bool isHui = true;
            //for (int i = 0; i < str.Length / 2; i++)
            //{
            //    if (str[i] != str[str.Length - 1 - i])
            //    {
            //        isHui = false;
            //        break;
            //    }
            //}
            //if (isHui)
            //{
            //    Console.WriteLine("是回文串");
            //}
            //else
            //{
            //    Console.WriteLine("不是回文串");
            //}

            //string str = Console.ReadLine();
            //string[] strArr = str.Split(' ');
            //int[] intArr = new int[strArr.Length];
            //for (int i = 0; i < strArr.Length; i++)
            //{
            //    int num = Convert.ToInt32(strArr[i]);
            //    intArr[i] = num;
            //}
            ////记录连续升温天数
            //int count = 1;
            ////最多连续升温天数
            //int maxDays = 0;
            //for (int i = 0; i < intArr.Length - 1; i++)
            //{
            //    if (intArr[i] < intArr[i + 1])
            //    {
            //        count++;
            //    }
            //    else
            //    {
            //        if (count > maxDays)
            //        {
            //            maxDays = count;
            //        }
            //        //计数器初始化
            //        count = 1;
            //    }
            //}
            //if (count > maxDays)
            //{
            //    maxDays = count;
            //}
            //Console.WriteLine("气温连续升高{0}天", maxDays);

            string str = Console.ReadLine();
            string[] strArr = str.Split(' ');
            int[] intArr = new int[strArr.Length];
            for (int i = 0; i < strArr.Length; i++)
            {
                int num = Convert.ToInt32(strArr[i]);
                intArr[i] = num;
            }
            int max1 = 0, max2 = 0;
            for (int i = 0; i < intArr.Length; i++)
            {
                //比最大值大
                if (intArr[i] > max1)
                {
                    max2 = max1;
                    max1 = intArr[i];
                }
                else
                {
                    //比第二大值大
                    if (intArr[i] > max2)
                    {
                        max2 = intArr[i];
                    }
                }
            }
            Console.WriteLine("第一大值是{0},第二大值是{1} ", max1, max2);

            Console.ReadKey();
        }
    }
}
