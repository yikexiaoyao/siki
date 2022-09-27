using System.Net.Sockets;
using System.Net;
using System.Text;

namespace _027_UDP服务器端
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Socket udpServer = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPAddress iPAddress = new IPAddress(new byte[] { 192, 168, 1, 103 });
            IPEndPoint iPEndPoint = new IPEndPoint(iPAddress, 7788);

            //绑定地址
            udpServer.Bind(iPEndPoint);

            Console.WriteLine("服务端已准备就绪，等待客户端连接 . . .");

            //接收信息
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 0);  //0 不限制端口号
            EndPoint ep = (EndPoint)ipep;   //强制类型转换
            byte[] data = new byte[1024];
            int length = udpServer.ReceiveFrom(data, ref ep);   //等待客户端发送信息，接收字节数
            string message1 = Encoding.UTF8.GetString(data, 0, length); //转码
            Console.WriteLine("接收到客户端信息：" + message1);

            udpServer.Close();
        }
    }
}