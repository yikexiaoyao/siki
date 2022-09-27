//定义宏
#define IsShowMessage

using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace _013_特性
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Test();

            //ShowMessage("Start of Main");
            //Console.WriteLine("Doing work in main");
            //ShowMessage("End of Main");

            ShowMessage("Hello");
        }

        //[Obsolete("这个方法弃用了，请使用最新的NewTest方法")]  //特性：弃用
        //private static void Test()
        //{
        //    Console.WriteLine("test");
        //}

        //private static void NewTest()
        //{
        //    Console.WriteLine("newTest");
        //}

        //[Conditional("IsShowMessage")]  //特性：条件
        //private static void ShowMessage(string str)
        //{
        //    Console.WriteLine(str);
        //}

        //[DebuggerStepThrough]   //特性：逐句执行debug
        private static void ShowMessage(string message, [CallerLineNumber] int lineNumber = 0, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "")
        {
            Console.WriteLine(message);
            Console.WriteLine(lineNumber);
            Console.WriteLine(filePath);
            Console.WriteLine(memberName);
        }
    }
}