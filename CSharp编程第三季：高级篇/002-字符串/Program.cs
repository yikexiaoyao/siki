namespace _002_字符串
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string s = "www.sikiedu.com";

            Console.WriteLine(s.Length);

            Console.WriteLine(s == "www.sikiedu.com");

            s = "http://" + s;

            Console.WriteLine(s);

            Console.WriteLine(s[3]);

            Console.WriteLine(s.CompareTo("sikiedu"));

            Console.WriteLine(s.Replace(".", "-")); //替换

            string[] arr = s.Split(".");    //切割
            foreach (string str in arr)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine(s.Substring(1));  //截取前几个
            Console.WriteLine(s.Substring(4, 4));   //从第几个索引开始截取几个

            Console.WriteLine(s.ToLower()); //全部小写
            Console.WriteLine(s.ToUpper()); //全部小写

            Console.WriteLine(s.Trim());    //去除前后空格

            Console.WriteLine(string.Concat("www.", "sikiedu.com"));    //拼接字符串

            char[] c1 = new char[20];
            s.CopyTo(4, c1, 1, 7);  //(从哪个索引开始,拷贝到哪个数组里,从哪个索引开始放入拷贝元素,需要拷贝几个元素)
            foreach (char c in c1)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine(c1);

            int x = 23;
            int y = 545;
            int he = x + y;
            Console.WriteLine(String.Format("{0}+{1}={2}", x, y, he));

            int money = 120000;
            Console.WriteLine(String.Format("{0:C}", money));   //货币格式输出

            Console.WriteLine(String.Format("{0:F2}", 23.12512));   //保留多少位小数

            Console.WriteLine(String.Format("{0:P}", 0.25657)); //百分比格式输出

            DateTime dt = DateTime.Now;
            Console.WriteLine(String.Format("{0:yyyy-MM-dd HH:mm:ss}", dt));
            Console.WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss"));

            Console.WriteLine(s.IndexOf("."));
            Console.WriteLine(s.IndexOfAny(".s".ToCharArray()));

            Console.WriteLine(s.Insert(3, "-"));

            char[] c2 = { 'A', 'B', 'C', 'D' };
            Console.WriteLine(string.Join("、", c2));
        }
    }
}