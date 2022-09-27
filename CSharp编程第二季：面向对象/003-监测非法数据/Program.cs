using System;

namespace _003_监测非法数据
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入两个数，每行一个");
            while (true)
            {
                try
                {
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(num1 + num2);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

            Console.ReadKey();
        }
    }
}
