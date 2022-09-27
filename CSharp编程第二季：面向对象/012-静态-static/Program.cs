using System;

namespace _012_静态_static
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t1 = new Test();
            t1.hp = 100;
            Console.WriteLine(t1.hp);
            Test t2 = new Test();
            t2.hp = 200;
            Console.WriteLine(t2.hp);

            Test.count = 1;
            Test.count = 2;
            Console.WriteLine(Test.count);

            Test.Move();

            Console.ReadKey();
        }
    }
}
