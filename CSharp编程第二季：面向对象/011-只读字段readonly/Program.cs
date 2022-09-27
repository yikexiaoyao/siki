using System;

namespace _011_只读字段readonly
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass b = new BaseClass(200);
            Console.WriteLine(b.hp);

            //b.hp = 300;   只读字段不能修改

            BaseClass b1 = new BaseClass();
            Console.WriteLine(b1.hp);

            Console.ReadKey();
        }
    }
}
