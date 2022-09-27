using System;

namespace _005_属性
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer lisi = new Customer();
            lisi.Age = 34;
            Console.WriteLine(lisi.Age);

            Console.ReadKey();
        }
    }
}
