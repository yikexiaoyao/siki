namespace _008_虚方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Boss b = new Boss();
            b.Move();

            Enemy enemy;
            enemy = new Boss();
            //enemy = new Type1Enemy();

            Enemy b1 = new Boss();
            b1.Move();

            b.AI();
            b1.AI();

            System.Console.ReadKey();
        }
    }
}
