using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _034_编程
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = Console.ReadLine();
            //char temp = ' ';
            //for (int i = 0; i < str.Length; i++)
            //{
            //    //有几个和自己相等
            //    int count = 0;
            //    for (int j = 0; j < str.Length; j++)
            //    {
            //        if (str[i] == str[j])
            //        {
            //            count++;
            //            if (count == 2)
            //            {
            //                break;
            //            }
            //        }
            //    }
            //    if (count == 1)
            //    {
            //        temp = str[i];
            //        break;
            //    }
            //}

            //if (temp == ' ')
            //{
            //    Console.WriteLine("no");
            //}
            //else
            //{
            //    Console.WriteLine(temp);
            //}

            //string str = Console.ReadLine();
            ////存放每个小写字母出现的次数
            //int[] countArr = new int[26];
            //for (int i = 0; i < str.Length; i++)
            //{
            //    countArr[str[i] - 'a']++;
            //}
            //bool isFound = false;
            //char c = ' ';
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (countArr[str[i] - 'a'] == 1)
            //    {
            //        isFound = true;
            //        c = str[i];
            //    }
            //}
            //if (isFound == false)
            //{
            //    Console.WriteLine("no");
            //} else
            //{
            //    Console.WriteLine(c);
            //}

            //string str = Console.ReadLine();
            ////a-z A-Z
            //int cha = 'A' - 'a';
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (str[i] >= 'a' && str[i]<= 'z')
            //    {
            //        char c = (char)(str[i] + cha);
            //        Console.Write(c);
            //    }
            //    else if (str[i] >= 'A' && str[i] <= 'Z')
            //    {
            //        char c = (char)(str[i] - cha);
            //        Console.Write(c);
            //    }
            //    else
            //    {
            //        Console.Write(str[i]);
            //    }
            //}

            string str = Console.ReadLine();
            string[] strArr = str.Split(' ');
            int[] intArr = new int[strArr.Length];
            for (int i = 0; i < strArr.Length; i++)
            {
                int num = Convert.ToInt32(strArr[i]);
                intArr[i] = num;
            }
            int n = Convert.ToInt32(Console.ReadLine());
            int index = -1;
            for (int i = 0; i < intArr.Length; i++)
            {
                if (n == intArr[i])
                {
                    index = i + 1;
                    break;
                }
            }
            Console.WriteLine(index);

            Console.ReadKey();
        }
    }
}
