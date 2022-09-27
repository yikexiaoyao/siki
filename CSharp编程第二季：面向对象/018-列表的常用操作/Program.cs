using System;
using System.Collections.Generic;

namespace _018_列表的常用操作
{
    class Program
    {
        static void ShowList(List<int> list)
        {
            foreach (int temp in list)
            {
                Console.Write(temp + " ");
            }
        }
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 56, 23, 894, 32, 5623, 4573 };

            //Console.WriteLine(list.Capacity);

            //list.Add(800);    //插到最后

            //Console.WriteLine(list[2]);

            //list.Insert(3, 800);    //(插到哪个索引对应的位置, 把谁)
            //ShowList(list);

            //list.Remove(32);    //只会移除匹配到的第一个数据
            //ShowList(list);

            //list.RemoveAt(2);   //移除哪个下标对应的数
            //ShowList(list);

            //Console.WriteLine(list.IndexOf(23));   //只会查找匹配到的第一个数据的索引  从前往后
            //Console.WriteLine(list.LastIndexOf(23));   //只会查找匹配到的第一个数据的索引  从后往前

            list.Sort();
            ShowList(list);

            Console.ReadKey();
        }
    }
}
