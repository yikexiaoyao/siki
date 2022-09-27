namespace _020_任务
{
    internal class Program
    {
        //private static void Test()
        //{
        //    for (int i = 0; i < 10000; i++)
        //    {
        //        Console.Write("A");
        //    }
        //}

        private static void FirstDownload()
        {
            Console.WriteLine("Downloading");
            Thread.Sleep(2000);
        }

        private static void SecondAlert(Task t)
        {
            Console.WriteLine("XXX下载完成");
        }

        private static void Main(string[] args)
        {
            ////方法一
            //TaskFactory tf = new TaskFactory();
            //Task t = tf.StartNew(Test);

            ////方法二
            //Task t = new Task(Test);
            //t.Start();

            //连续任务
            Task t1 = new Task(FirstDownload);
            Task t2 = t1.ContinueWith(SecondAlert);
            t1.Start();

            Thread.Sleep(5000);
        }
    }
}