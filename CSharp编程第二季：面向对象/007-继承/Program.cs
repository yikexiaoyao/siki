using System;

namespace _007_继承
{
    class Program
    {
        static void Main(string[] args)
        {
            //BaseClass b = new BaseClass();
            //b.data1 = 12;
            //b.data2 = "3213213hjhkhjkcjxkjcd";
            //Console.WriteLine(b.data2);
            //b.Function1();
            //b.Function2();

            //DrivedClass1 d1 = new DrivedClass1();
            //d1.Function1();
            //d1.Function2();
            //d1.data1 = 100;
            //Console.WriteLine(d1.data1);

            //DrivedClass2 d2 = new DrivedClass2();
            //d2.Function2();

            Boss boss1 = new Boss(100, 100000, 20);
            boss1.Print();

            Console.ReadKey();
        }
    }
}
