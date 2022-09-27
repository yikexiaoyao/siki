using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _029_数组
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] ages = { 34, 12, 56, 67, 2, 3, 4, 6, 6, 2 };
            //Console.WriteLine(ages[7]);

            //int[] ages;
            //ages = new int[10];
            //Console.WriteLine(ages[5]); //默认值0

            //int[] ages = new int[] { 34, 12, 56, 67, 2, 3, 4, 6, 6, 2 };
            //ages[4] = 20;
            //Console.WriteLine(ages[4]);

            //int[] a = new int[9];
            //char[] b = new char[20];
            //float[] c = new float[5];
            //string[] d = new string[8];

            int[] ages = { 34, 12, 56, 67, 2, 3, 4, 6, 6, 2 };

            //for (int i = 0; i < ages.Length; i++)
            //{
            //    Console.WriteLine(ages[i]);
            //}

            for (int i = ages.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(ages[i]);
            }

            //int i = 0;
            //while (i < ages.Length)
            //{
            //    Console.WriteLine(ages[i]);
            //    i++;
            //}

            //foreach (int temp in ages)
            //{
            //    Console.WriteLine(temp);
            //}

            Console.ReadKey();
        }
    }
}
