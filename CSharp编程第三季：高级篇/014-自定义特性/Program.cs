namespace _014_自定义特性
{
    [Information("Siki", "v1.1", "这是用来发射核弹的类")]
    internal class Program
    {
        private static void Main(string[] args)
        {
            Type t = typeof(Program);

            bool result = t.IsDefined(typeof(InformationAttribute), false);
            Console.WriteLine(result);

            object[] attributeArray = t.GetCustomAttributes(false);
        }
    }
}