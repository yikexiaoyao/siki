namespace _048_委托
{
    class Program
    {
        static double Multiply(double param1, double param2)
        {
            return param1 * param2;
        }
        static double Divide(double param1, double param2)
        {
            return param1 / param2;
        }
        static void Test()
        {
            System.Console.WriteLine("Test");
        }
        //委托
        delegate double MyDelegate(double param1, double param2);
        delegate void MyDelegate2();

        static void Main(string[] args)
        {
            System.Console.WriteLine(Multiply(2.3, 2));
            System.Console.WriteLine(Divide(4.5, 3));

            MyDelegate delegate1;
            //指向函数
            delegate1 = Multiply;
            System.Console.WriteLine(delegate1(2, 4));

            MyDelegate2 delegate2;
            delegate2 = Test;
            delegate2();

            System.Console.ReadKey();
        }
    }
}
