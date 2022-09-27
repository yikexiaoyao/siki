using System.Text;

namespace _003_字符串StringBuilder
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //StringBuilder sb = new StringBuilder("www.sikiedu.com");
            //sb.Append("123");
            //sb.Append("abc");
            //sb.Insert(3, " ");
            //sb.Remove(4, 2);
            //sb.Replace("i", "爱");
            //Console.WriteLine(sb);

            string s = "http://" + "www.sikiedu.com";

            StringBuilder sb = new StringBuilder();
            sb.Append("http://");
            sb.Append("www.sikiedu.com");
        }
    }
}