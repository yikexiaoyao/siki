using System.Net;
using System.Net.Sockets;
using System.Text;

namespace _026_TCP客户端TcpClient
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Socket tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress iPAddress = new IPAddress(new byte[] { 192, 168, 1, 105 });
            IPEndPoint iPEndPoint = new IPEndPoint(iPAddress, 7788);

            //连接地址
            tcpClient.Connect(iPEndPoint);
            Console.WriteLine("客户端已上线 . . .");

            //发送信息
            string message1 = Convert.ToString(Console.ReadLine());
            tcpClient.Send(Encoding.UTF8.GetBytes(message1));    //转码

            //接收信息
            byte[] data = new byte[1024];
            int length = tcpClient.Receive(data);  //接收字节数
            string message2 = Encoding.UTF8.GetString(data, 0, length);   //转码
            Console.WriteLine("接收到服务端信息：" + message2);

            tcpClient.Close();
        }
    }
}