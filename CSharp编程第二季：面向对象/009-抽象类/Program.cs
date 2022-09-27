using System;

namespace _009_抽象类
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy e = new Boss();
            e.Attack();

            Console.ReadKey();
        }
    }
}
