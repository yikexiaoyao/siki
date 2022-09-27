using System;

namespace _005_属性
{
    //顾客类
    class Customer
    {
        private string name;
        private string address;
        private int age;
        private string createTime;

        public string Name
        {
            set //value参数
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        public string Address
        {
            set //value参数
            {
                address = value;
            }
            get
            {
                return address;
            }
        }
        public int Age
        {
            set //value参数
            {
                if (age < 0)
                {
                    return;
                }
                age = value;
            }
            get
            {
                return age;
            }
        }
        public string CreateTime
        {
            set //value参数
            {
                createTime = value;
            }
            get
            {
                return createTime;
            }
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
