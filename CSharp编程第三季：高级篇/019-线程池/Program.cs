namespace _019_线程池
{
    internal class Program
    {
        private static void Download(object o)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Downloading . . . " + Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(100);
            }
        }

        private static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(Download);
            }
            Thread.Sleep(5000);
        }
    }
}