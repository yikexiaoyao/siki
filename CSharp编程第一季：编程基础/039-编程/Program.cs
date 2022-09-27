using System;

namespace _039_编程
{
    class Program
    {
        //static int Max(int[] arr)
        //{
        //    int max = arr[0];
        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        if (arr[i] > max)
        //        {
        //            max = arr[i];
        //        }
        //    }
        //    return max;
        //}
        static int[] getYinZi(int num)
        {
            //获取因子个数
            int count = 0;
            for (int i = 1; i < num + 1; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            //存放因子
            int[] arr = new int[count];
            //索引
            int index = 0;
            for (int i = 1; i < num + 1; i++)
            {
                if (num % i == 0)
                {
                    arr[index] = i;
                    //index 随 i 自增
                    index++;
                }
            }
            return arr;
        }
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
            //int reult = Max(intArr);
            //Console.WriteLine(reult);

            int num = Convert.ToInt32(Console.ReadLine());
            int[] arr = getYinZi(num);
            foreach (int temp in arr)
            {
                Console.Write(temp + " ");
            }

            Console.ReadKey();
        }
    }
}
