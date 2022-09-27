namespace _015_线程Thread
{
    internal class Program
    {
        public struct Data
        {
            public string message;
            public int age;
        }

        private static void Test()
        {
            Console.WriteLine("Started");
            Thread.Sleep(1000);
            Console.WriteLine("Ended");
        }

        private static void Download(object o)
        {
            //强制转换
            //string str = (string)o;
            Data data = (Data)o;
            Console.WriteLine(data);
        }

        private static void Main(string[] args)
        {
            //Thread t = new Thread(Test);

            //Thread t = new Thread(() => Console.WriteLine("Child Thread:" + Thread.CurrentThread.ManagedThreadId));

            ////匿名方法
            //Thread t = new Thread(delegate ()
            //{
            //});

            //t.Start();
            //Console.WriteLine("Main Completed:" + Thread.CurrentThread.ManagedThreadId);

            Data data = new Data();
            data.message = "";
            data.age = 12;
            Thread t = new Thread(Download);
            //t.Start("https://www.baidu.com");
            t.Start(data);
            Console.WriteLine("Main Completed:" + Thread.CurrentThread.ManagedThreadId);
        }
    }
}