namespace _022_文件操作
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //FileInfo myFile = new FileInfo(@"C:\Users\华硕\source\repos\siki\CSharp编程第三季：高级篇\022-文件操作\Test.txt");
            //myFile.CopyTo(@"C:\Users\华硕\source\repos\siki\CSharp编程第三季：高级篇\022-文件操作\HelloWorld.txt");

            //File.Copy(@"C:\Users\华硕\source\repos\siki\CSharp编程第三季：高级篇\022-文件操作\Test.txt",
            //    @"C:\Users\华硕\source\repos\siki\CSharp编程第三季：高级篇\022-文件操作\Test.txt");

            //DirectoryInfo myFolder = new DirectoryInfo(@"C:\Users\华硕\source\repos\siki\CSharp编程第三季：高级篇\022-文件操作\"); //绝对路径
            //myFolder.Create();
            //Directory.CreateDirectory(@"create\child"); //相对路径
            //Console.WriteLine(myFolder.Root.FullName);  //根目录

            //FileInfo myFile = new FileInfo(@"C:\Users\华硕\source\repos\siki\CSharp编程第三季：高级篇\022-文件操作\Test.txt");
            //myFile.LastWriteTime = DateTime.Now;    //修改写入时间为当前时间

            //string psthStr = Path.Combine(@"C:", @"Users\华硕\source\repos\siki");    //拼接路径
            //Console.WriteLine(psthStr);

            ////文本读取
            //string text = File.ReadAllText(@"C:\Users\华硕\source\repos\siki\CSharp编程第三季：高级篇\022-文件操作\Test.txt", System.Text.Encoding.ASCII);
            //Console.WriteLine(text);
            ////逐行读取
            //string[] strArray = File.ReadAllLines(@"C:\Users\华硕\source\repos\siki\CSharp编程第三季：高级篇\022-文件操作\Test.txt");
            //foreach (string str in strArray)
            //{
            //    Console.WriteLine(str);
            //}
            ////逐个字节读取
            //byte[] byteArray = File.ReadAllBytes(@"C:\Users\华硕\source\repos\siki\CSharp编程第三季：高级篇\022-文件操作\Test.txt");
            //foreach (byte b in byteArray)
            //{
            //    Console.WriteLine(b);
            //}

            //文本写入
            File.WriteAllText(@"C:\Users\华硕\source\repos\siki\CSharp编程第三季：高级篇\022-文件操作\Test.txt", "www.baidu.com");
            //逐行写入
            File.WriteAllLines(@"C:\Users\华硕\source\repos\siki\CSharp编程第三季：高级篇\022-文件操作\Test.txt", new string[] { "123", "233" });
        }
    }
}