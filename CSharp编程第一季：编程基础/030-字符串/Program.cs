using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030_字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Micheal";
            //name = "Micheal" + " 123";
            //name = "" + 45;
            //Console.Write(name.Length);
            //Console.Write(name[3]);
            //for (int i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            //string name = " Micheal Liang ";
            //string str1 = name.ToLower();
            //Console.WriteLine(name + "-" + str1);
            //string str2 = name.ToUpper();
            //Console.WriteLine(name + "-" + str2);
            //string str3 = name.Trim();
            //Console.WriteLine(name + "-" + "|" + str3 + "|");
            //string str4 = name.TrimStart();
            //Console.WriteLine(name + "-" + "|" + str4 + "|");
            //string str5 = name.TrimEnd();
            //Console.WriteLine(name + "-" + "|" + str5 + "|");

            string name = "xiaoming,zhangsan,xiaohong";
            string[] str = name.Split(',');
            foreach (string item in str)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
