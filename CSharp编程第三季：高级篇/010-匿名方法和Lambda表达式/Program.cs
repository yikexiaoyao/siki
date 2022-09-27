namespace _010_匿名方法和Lambda表达式
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Func<int, int, int> plus = delegate (int a, int b)
            //{
            //    return a + b;
            //};
            Func<int, int, int> plus = (a, b) =>
            {
                return a + b;
            };
            int result = plus(1, 2);
            Console.WriteLine(result);

            //Func<double, double> square = x => x * x;

            int a = 5;
            Func<int, int> f = x => x + a;
            Console.WriteLine(f(4));
            a = 8;
            Console.WriteLine(f(4));
        }
    }
}