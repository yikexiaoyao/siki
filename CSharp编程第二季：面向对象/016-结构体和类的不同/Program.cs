using System;

namespace _016_结构体和类的不同
{
    class Program
    {
        struct StudentStu
        {
            public int age;
            public string name;

            public StudentStu(int age, string name)
            {
                this.age = age;
                this.name = name;
            }
        }
        static void Main(string[] args)
        {
            ////Student 类
            ////存放在堆里
            //Student s1 = new Student(18, "小芳");
            //Student s2 = new Student(25, "小刚");
            //栈里s2存放s1地址
            //s2 = s1;
            //修改s1数据则s2也会随之改变
            //s1.age = 30;
            //s1.name = "小燕";
            //Console.WriteLine(s2.age);
            //Console.WriteLine(s2.name);

            //StudentStu 结构体
            //存放在栈里
            StudentStu stu1 = new StudentStu(18, "小芳");
            StudentStu stu2 = stu1; //重新创建内存区域存放修改后的数据
            //修改s1数据s2不受影响
            stu1.age = 30;
            stu1.name = "小燕";
            Console.WriteLine(stu2.age);
            Console.WriteLine(stu2.name);

            StudentStu s1 = new StudentStu(18, "小芳");
            StudentStu s2 = new StudentStu(25, "小刚");
            s2 = s1;
            s1.age = 30;
            s1.name = "小燕";
            Console.WriteLine(s2.age);
            Console.WriteLine(s2.name);

            Console.ReadKey();
        }
    }
}
