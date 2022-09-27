using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_多线程_自定义类传递数据
{
    internal class DownloadTool
    {
        public string URL { private set; get; }
        public string Message { private set; get; }

        public DownloadTool(string uRL, string message)
        {
            URL = uRL;
            Message = message;
        }

        public void Download()
        {
            Console.WriteLine("从" + URL + "下载中 . . .");
        }
    }
}