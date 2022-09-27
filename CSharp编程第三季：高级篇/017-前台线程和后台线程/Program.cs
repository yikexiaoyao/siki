namespace _017_前台线程和后台线程
{
    internal class Program
    {
        private static void ThreadMain()
        {
            Console.WriteLine("Thread " + Thread.CurrentThread.Name + " Started");
            Thread.Sleep(3000);
            Console.WriteLine("Thread " + Thread.CurrentThread.Name + " Started");
        }

        private static void Main(string[] args)
        {
            //var t1 = new Thread(ThreadMain)
            //{
            //    IsBackground = false
            //};
            //t1.Start();
            //Console.WriteLine("Main thread ending now");

            Student student1 = new Student(20, "张三");
            Student student2 = new Student() { Age = 15, Name = "Micheal" };
        }
    }
}