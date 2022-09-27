using System;

namespace CSharp编程第二季_面向对象
{
    class Program
    {
        static int Add(int a, int b)
        {
            int result = a + b;
            //Console.WriteLine("Method:" + result);
            return result;
        }
        static void Main(string[] args)
        {
            int result = Add(20, 30);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
