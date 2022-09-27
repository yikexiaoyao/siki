namespace _016_多线程_自定义类传递数据
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DownloadTool downloadTool = new DownloadTool("https://www.baidu.com", "sdfsdf");
            Thread t = new Thread(downloadTool.Download);
            t.Start();
        }
    }
}