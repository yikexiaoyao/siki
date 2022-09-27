using System.Net;
using System.Net.Sockets;
using System.Text;

namespace _025_TCP服务器端TcpServer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Socket tcpServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress iPAddress = new IPAddress(new byte[] { 192, 168, 1, 105 });
            IPEndPoint iPEndPoint = new IPEndPoint(iPAddress, 7788);

            //绑定地址
            tcpServer.Bind(iPEndPoint);

            //限制连接数
            tcpServer.Listen(100);

            //开始监听，等待客户端连接
            Console.WriteLine("服务端已准备就绪，等待客户端连接 . . .");
            Socket tcpClient = tcpServer.Accept();
            Console.WriteLine("一个客户端已接入 . . .");

            //接收信息
            byte[] data = new byte[1024];
            int length = tcpClient.Receive(data);  //接收字节数
            string message1 = Encoding.UTF8.GetString(data, 0, length);   //转码
            Console.WriteLine("接收到客户端信息：" + message1);

            //发送信息
            string message2 = Convert.ToString(Console.ReadLine());
            tcpClient.Send(Encoding.UTF8.GetBytes(message2));

            tcpClient.Close();
            tcpServer.Close();
        }
    }
}