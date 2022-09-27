using System;

namespace _006_值类型和引用类型的内存存储
{
    //顾客类
    class Customer
    {
        public string name;
        public string address;
        public int age;
        public string createTime;

        public Customer(string name, string address, int age, string createTime)
        {
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
