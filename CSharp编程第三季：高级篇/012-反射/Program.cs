using System.Reflection;

namespace _012_反射
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Type t = typeof(MyClass);
            MyClass myClass = new MyClass();
            Type t = myClass.GetType();

            Console.WriteLine(t.Name);
            Console.WriteLine(t.Namespace);
            Console.WriteLine(t.Assembly);

            FieldInfo[] fis = t.GetFields();
            foreach (FieldInfo fi in fis)
            {
                Console.WriteLine(fi.Name);
            }
            PropertyInfo[] pis = t.GetProperties();
            foreach (PropertyInfo pi in pis)
            {
                Console.WriteLine(pi.Name);
            }
            MethodInfo[] mis = t.GetMethods();
            foreach (MethodInfo mi in mis)
            {
                Console.WriteLine(mi.Name);
            }
        }
    }
}