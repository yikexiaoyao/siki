using System;

namespace _002_异常处理
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = { 1, 2, 3, 4 };
            try
            {
                int myEle = myArr[4];
                Console.WriteLine(myEle);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("程序已执行。。。。。。");
            }

            Console.ReadKey();
        }
    }
}
