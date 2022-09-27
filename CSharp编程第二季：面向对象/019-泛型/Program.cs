using System;

namespace _019_泛型
{
    class ClassA<T> //  Type
    {
        private T a;
        private T b;

        public ClassA(T a, T b)
        {
            this.a = a;
            this.b = b;
        }
        public T GetSum()
        {
            //声明动态类型
            dynamic num1 = a;
            dynamic num2 = b;
            dynamic result = num1 + num2;
            return result;
        }
    }

    class Program
    {
        //泛型方法
        public static T GetSum<T>(T a, T b)
        {
            dynamic num1 = a;
            dynamic num2 = b;
            return (T)(num1 + num2);
        }
        static void Main(string[] args)
        {
            ClassA<int> a1 = new ClassA<int>(34, 12);
            Console.WriteLine(a1.GetSum());
            ClassA<double> a2 = new ClassA<double>(2.3, 6.3);
            Console.WriteLine(a2.GetSum());

            Student s = new Student(30, "小凡");
            Console.WriteLine(s);

            Console.WriteLine(GetSum(34, 56));

            Console.WriteLine(GetSum<int>(23, 45));

            Console.ReadKey();
        }
    }
}
