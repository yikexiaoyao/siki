using System;

namespace _014_索引器
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 34, 567, 432, 4, 32 };
            //Console.WriteLine(arr[1]);

            //Test t = new Test();
            ////t[9] = 200;
            //Console.WriteLine(t[9]);

            //Test t = new Test();
            //t[0] = "张三";
            //t[1] = "李四";
            //Console.WriteLine(t[0]);
            //Console.WriteLine(t[1]);

            Week w = new Week();
            //Console.WriteLine(w.getDay("Thu"));
            Console.WriteLine(w["Thu"]);

            Console.ReadKey();
        }
    }
}
