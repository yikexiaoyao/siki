using System;

namespace _015_运算符重载
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(12903, "张三", 20);
            Student s2 = new Student(12903, "张三", 20);
            Console.WriteLine(s1 == s2);
            Console.WriteLine(s1 != s2);

            Console.ReadKey();
        }
    }
}
