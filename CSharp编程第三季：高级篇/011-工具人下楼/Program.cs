namespace _011_工具人下楼
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ToolMan toolMan = new ToolMan("小明");
            LazyMan lazyMan1 = new LazyMan("张三");
            LazyMan lazyMan2 = new LazyMan("李四");
            LazyMan lazyMan3 = new LazyMan("王五");

            toolMan.downStairDelegate += lazyMan1.TakeFood;
            toolMan.downStairDelegate += lazyMan2.TakePackage;
            toolMan.downStairDelegate += lazyMan3.TakeFood;
            toolMan.DownStair();
            Console.WriteLine("--------------------");

            toolMan.downStairDelegate -= lazyMan3.TakeFood;
            toolMan.DownStair();
            Console.WriteLine("--------------------");

            ////受限
            //toolMan.downStairDelegate = lazyMan3.TakeFood;
            //toolMan.downStairDelegate();
        }
    }
}