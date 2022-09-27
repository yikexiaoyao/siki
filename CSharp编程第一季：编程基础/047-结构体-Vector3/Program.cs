using System;

namespace _047_结构体_Vector3
{
    class Program
    {
        struct Vector3
        {
            public double x;
            public double y;
            public double z;
            public double Distance()
            {
                double temp = x * x + y * y + z * z;
                return Math.Sqrt(temp);
            }
        }
        static void Main(string[] args)
        {
            Vector3 v1;
            v1.x = 4;
            v1.y = 5;
            v1.z = 7;
            Console.WriteLine(v1.Distance());

            Console.ReadKey();
        }
    }
}
