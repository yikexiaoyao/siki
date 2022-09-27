using System.Text.RegularExpressions;

namespace _004_正则表达式
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string s1 = "43432n";
            string s2 = "234234";

            //任一字符是数字
            Console.WriteLine(Regex.IsMatch(s1, @"\d"));
            Console.WriteLine(Regex.IsMatch(s2, @"\d"));

            //6个连续字符是数字
            Console.WriteLine(Regex.IsMatch(s1, @"\d\d\d\d\d\d"));
            Console.WriteLine(Regex.IsMatch(s2, @"\d\d\d\d\d\d"));

            //包含0个或多个数字
            Console.WriteLine(Regex.IsMatch(s1, @"\d*"));
            Console.WriteLine(Regex.IsMatch(s2, @"\d*"));

            //包含 si sii siii . . .
            Console.WriteLine(Regex.IsMatch(s1, @"si*"));
            Console.WriteLine(Regex.IsMatch(s2, @"si*"));

            //以“4”开头
            Console.WriteLine(Regex.IsMatch(s1, @"^4"));
            Console.WriteLine(Regex.IsMatch(s2, @"^4"));

            //以“4”结尾
            Console.WriteLine(Regex.IsMatch(s1, @"4$"));
            Console.WriteLine(Regex.IsMatch(s2, @"4$"));

            //以数字开头，以数字结尾
            Console.WriteLine(Regex.IsMatch(s1, @"^\d*$"));
            Console.WriteLine(Regex.IsMatch(s2, @"^\d*$"));

            //以大小写字母开头，以大小写字母结尾
            Console.WriteLine(Regex.IsMatch(s1, @"^\w*$"));
            Console.WriteLine(Regex.IsMatch(s2, @"^\w*$"));

            Console.WriteLine(Regex.IsMatch("a", @"[abcd]"));
            Console.WriteLine(Regex.IsMatch("e", @"[abcd]"));
            Console.WriteLine(Regex.IsMatch("b", @"[a-gx-z]"));
            Console.WriteLine(Regex.IsMatch("h", @"[a-gx-z]"));
            Console.WriteLine(Regex.IsMatch("h", @"[A-H]"));
            Console.WriteLine(Regex.IsMatch("h", @"[^A-H]"));   //除了A-H之外的其他大小写字母

            //是否为合法标识符
            string re = @"^[a-zA-Z_]\w*$";
            Console.WriteLine(Regex.IsMatch("sdfd", re));
            Console.WriteLine(Regex.IsMatch("23dfd", re));
            Console.WriteLine(Regex.IsMatch("sdf3dD", re));
            Console.WriteLine(Regex.IsMatch("_sdf3d-D", re));

            //替换
            string str = "www.sikiedu.com";
            Console.WriteLine(Regex.Replace(str, @"[a-z]", "*"));

            //5-12个
            string s = @"^\d{5,12}$";
            Console.WriteLine(Regex.IsMatch("456", s));
            Console.WriteLine(Regex.IsMatch("4d56", s));
            Console.WriteLine(Regex.IsMatch("1234567891248", s));
            Console.WriteLine(Regex.IsMatch("654874", s));

            //择一匹配
            Console.WriteLine(Regex.IsMatch("4", @"\d|a"));
            Console.WriteLine(Regex.IsMatch("a", @"\d|a"));
            Console.WriteLine(Regex.IsMatch("b", @"\d|a"));

            Console.WriteLine(Regex.IsMatch("aa", @"a{2}"));    //aa
            Console.WriteLine(Regex.IsMatch("ab", @"a{2}"));
            Console.WriteLine(Regex.IsMatch("abb", @"ab{2}"));   //abb
            Console.WriteLine(Regex.IsMatch("abab", @"(ab){2}"));   //abab
            Console.WriteLine(Regex.IsMatch("(", @"\("));
        }
    }
}