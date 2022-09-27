namespace _023_文件操作_流
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DateTime before = DateTime.Now;

            //路径    打开方式    权限
            FileStream readFileStream = new FileStream(@"C:\Users\华硕\source\repos\siki.zip", FileMode.Open, FileAccess.Read);
            //readFileStream.ReadByte();
            FileStream writeFileStream = new FileStream(@"C:\Users\华硕\source\repos\sikiCopy.zip", FileMode.Create, FileAccess.Write);
            //writeFileStream.WriteByte();

            //边读边写
            ////优化前
            //int nextByte = -1;
            //while ((nextByte = readFileStream.ReadByte()) != 0)
            //{
            //    writeFileStream.WriteByte((byte)nextByte);
            //}

            //优化后
            int length = 1024;  //可根据内存大小进行增大或减小
            byte[] buffer = new byte[length];
            int count = -1;
            while ((count = readFileStream.Read(buffer, 0, buffer.Length)) != 0)  //实际读取字节数
            {
                writeFileStream.Write(buffer, 0, count);
            }

            //关闭流
            writeFileStream.Close();
            readFileStream.Close();

            DateTime after = DateTime.Now;

            TimeSpan ts = after.Subtract(before);   //获取时间差
            Console.WriteLine(ts.TotalMilliseconds);    //毫秒
        }
    }
}