using System;
using System.Collections.Generic;

namespace _017_列表List
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>() { 321, 653, 832 };
            //list.Add(900);
            //list.Add(6732);
            //list[3] = 9;

            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            //Console.WriteLine(list.Count + ":" + list.Capacity);

            List<int> list = new List<int>(50);
            list.Add(34);
            list.Add(234);
            foreach (int temp in list)
            {
                Console.WriteLine(temp);
            }

            Console.ReadKey();
        }
    }
}
