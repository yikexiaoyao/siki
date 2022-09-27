using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _036_函数
{
    class Program
    {
        static bool VeryfyUserName(string username)
        {
            Console.WriteLine("校验逻辑修改");
            Console.WriteLine("校验用户名" + username);
            return true;
        }
        static int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }
        static void Main(string[] args)
        {
            //bool result = VeryfyUserName("张三");
            //Console.WriteLine(result);

            int res = Add(10, 12);
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
