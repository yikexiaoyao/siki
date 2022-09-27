using System;

namespace _021_Equals判断相等
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12;
            int b = 12;
            Console.WriteLine(a.Equals(b));

            string str1 = "siki";
            string str2 = "sikiedu";
            Console.WriteLine(str1.Equals(str2));

            Student s1 = new Student(18, "小芳");
            Student s2 = new Student(18, "小芳");
            Console.WriteLine(s1.Equals(s2));
            Console.WriteLine(s1 == s2);    //s1和s2引用地址不同

            Console.ReadKey();
        }
    }
}
