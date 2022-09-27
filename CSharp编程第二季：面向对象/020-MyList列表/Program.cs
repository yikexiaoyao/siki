using System;

namespace _020_MyList列表
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            Console.WriteLine(list.Capacity);

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            Console.WriteLine(list.Count);

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();

            list.Insert(2, 100);
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();

            //移除数据”3“
            list.RemoveAt(3);
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();

            //获取数据“100”的索引
            Console.WriteLine(list.IndexOf(100));

            list.Add(4);
            Console.WriteLine(list.IndexOf(4));
            Console.WriteLine(list.LastIndexOf(4));

            list.Sort();
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
