using System;

namespace _038_参数数组
{
    class Program
    {
        static int Add(int[] arr)
        {
            int sum = 0;
            foreach (int temp in arr)
            {
                sum += temp;
            }
            return sum;
        }
        static int Add1(params int[] arr)   //传递任意个数参数
        {
            int sum = 0;
            foreach (int temp in arr)
            {
                sum += temp;
            }
            return sum;
        }
        static int Add2(string name, params int[] arr)   //传递任意个数参数
        {
            int sum = 0;
            foreach (int temp in arr)
            {
                sum += temp;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 4, 8 };
            int result = Add(arr);
            Console.WriteLine(result);

            int result1 = Add1(6, 8, 9);
            Console.WriteLine(result1);

            int result2 = Add2("zhangsan", 1, 3, 5, 7, 9, 2);
            Console.WriteLine(result2);

            Console.ReadKey();
        }
    }
}
