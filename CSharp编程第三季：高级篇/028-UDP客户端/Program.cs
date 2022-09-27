using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;

namespace _028_UDP客户端
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Socket udpClient = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPAddress iPAddress = new IPAddress(new byte[] { 192, 168, 1, 103 });
            IPEndPoint iPEndPoint = new IPEndPoint(iPAddress, 7788);

            Console.WriteLine("客户端已上线 . . .");

            //发送信息
            string message1 = Convert.ToString(Console.ReadLine());
            udpClient.SendTo(Encoding.UTF8.GetBytes(message1), iPEndPoint);    //转码

            udpClient.Close();
        }
    }
}