namespace _024_文本读取流和写入流
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string sourceFile = @"C:\Users\华硕\source\repos\siki\CSharp编程第三季：高级篇\024-文本读取流和写入流\Test.txt";
            StreamReader reader = new StreamReader(sourceFile);

            ////方法一：文本读取
            //FileStream fs = new FileStream(sourceFile,FileMode.Open);
            //StreamReader reader = new StreamReader(fs);

            ////方法二
            //FileInfo myFile = new FileInfo(sourceFile);
            //myFile.OpenText();  //文本读取流

            ////读取一行
            //string line = reader.ReadLine();
            //Console.WriteLine(line);

            ////读取所有
            //string line = null;
            //while ((line = reader.ReadLine()) != null)
            //{
            //    Console.WriteLine(line);
            //}

            string targetFile = @"C:\Users\华硕\source\repos\siki\CSharp编程第三季：高级篇\024-文本读取流和写入流\TestCopy.txt";
            StreamWriter writer = new StreamWriter(targetFile, true);   //追加

            string line = null;
            while ((line = reader.ReadLine()) != null)
            {
                writer.WriteLine(line);
            }

            writer.Close();
            reader.Close();
        }
    }
}