using System;

namespace _004_面向对象
{
    //顾客类
    class Customer
    {
        public string name;
        public string address;
        public int age;
        public string createTime;

        public Customer()
        {
            Console.WriteLine("我是构造函数");
        }

        public Customer(string name, string address, int age, string createTime)
        {
            //name = arg1;
            //address = arg2;
            //age = arg3;
            //createTime = arg4;
            this.name = name;
            this.address = address;
            this.age = age;
            this.createTime = createTime;
        }

        public void Show()
        {
            Console.WriteLine("姓名:" + name);
            Console.WriteLine("地址:" + address);
            Console.WriteLine("年龄:" + age);
            Console.WriteLine("创建时间:" + createTime);
        }
    }
}
