namespace _018_线程的优先级
{
    internal class Program
    {
        private static void A()
        {
            while (true)
            {
                Console.Write("A");
            }
        }

        private static void B()
        {
            while (true)
            {
                Console.Write("B");
            }
        }

        private static void Main(string[] args)
        {
            Thread a = new Thread(A);
            Thread b = new Thread(B);

            //a.Priority = ThreadPriority.Highest;    //最高优先级
            //b.Priority = ThreadPriority.Lowest;    //最低优先级

            //a.Start();
            b.Start();

            b.Join();   //等待 b 线程结束
        }
    }
}