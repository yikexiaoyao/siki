namespace _005_委托
{
    internal class Program
    {
        //private delegate string GetAString();

        //private delegate void IntMethodInvoker(int x);

        //private delegate long TwoLong(long a, long b);

        private delegate double DoubleOpDelegate(double x);

        private static void Main(string[] args)
        {
            //IntMethodInvoker invoker = null;
            //TwoLong invoker2 = null;

            //invoker = test;
            //invoker(100);
            //if (invoker2 != null)
            //{
            //    invoker2(2, 23);
            //}
            //int x = 1123;
            ////GetAString getAString = x.ToString;
            //GetAString getAString = new GetAString(x.ToString);
            //Console.WriteLine(getAString());

            DoubleOpDelegate[] operations = { MathOp.MultiplyByTwo, MathOp.Square };
            foreach (DoubleOpDelegate op in operations)
            {
                //Console.WriteLine(op(3));
                ProcessAndDisplayRes(op, 4);
            }
        }

        //private static void test(int x)
        //{
        //    Console.WriteLine("我是test方法：" + x);
        //}

        private static void ProcessAndDisplayRes(DoubleOpDelegate op, double value)
        {
            double result = op(value);
            Console.WriteLine("Result:" + result);
        }
    }
}