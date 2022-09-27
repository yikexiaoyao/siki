using System;

namespace _004_面向对象
{
    class Program
    {
        static void Main(string[] args)
        {
            ////创建对象
            //Customer c1 = new Customer();
            ////生命对象
            //Customer c2;
            ////对象实例化
            //c2 = new Customer();

            //c1.name = "张三";
            //c1.address = "江苏";
            //c1.age = 20;
            //c1.createTime = "2022年8月24日";

            //c1.Show();

            //Vehicle car1 = new Vehicle();
            //car1.Run();
            //car1.Stop();

            //Vector3 v1 = new Vector3();
            //v1.SetX(2.3);
            //v1.SetY(4.5);
            //v1.SetZ(6.7);
            //Console.WriteLine(v1.Distance());

            Customer lisi = new Customer();
            lisi.Show();

            Customer zhangsan = new Customer("张三", "三里屯", 20, "2022年8月25日");
            zhangsan.Show();

            Console.ReadKey();
        }
    }
}
