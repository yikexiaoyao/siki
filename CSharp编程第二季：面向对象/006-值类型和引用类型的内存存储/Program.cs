namespace _006_值类型和引用类型的内存存储
{
    class Program
    {
        static void Main(string[] args)
        {
            ////栈
            //int a = 123;
            //double b = 34.5;
            //bool c = true;

            ////静态存储区域
            //string name = "siki";   //地址存在栈中

            ////堆
            //int[] arr1 = new int[] { 23, 23, 11, 32, 4, 2345 }; //地址存在栈中
            //string[] arr2 = new string[] { "www", "sikiedu", "com" };   //地址存在栈中    字符串元素：每个元素位存储的都是该元素的地址，元素存储在静态存储区域
            //Customer c1 = new Customer("张三","三里屯",13,"2021");   //地址存在栈中

            //Customer c1 = new Customer("张三", "三里屯", 13, "2021");
            //Customer c2 = new Customer("李四", "北京", 20, "2022");

            //c1.Show();
            //c1.name = "zhangsan";
            //c1.Show();

            Customer c1 = new Customer("张三", "三里屯", 13, "2021");
            Customer c2 = c1;
            c1.Show();
            c2.Show();
            c1.name = "zhangsan";
            c1.Show();
            c2.Show();

            System.Console.ReadKey();
        }
    }
}
