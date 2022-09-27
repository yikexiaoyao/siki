namespace _009_多播委托
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Action action1 = Test1;
            action1 += Test2;
            //action1 -= Test1;
            //action1();
            Delegate[] delegates = action1.GetInvocationList(); //获取委托集合
            foreach (Delegate d in delegates)
            {
                //动态调用
                d.DynamicInvoke();
            }
        }

        private static void Test1()
        {
            Console.WriteLine("test1");
        }

        private static void Test2()
        {
            Console.WriteLine("test2");
        }
    }
}