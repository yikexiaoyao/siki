using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_前台线程和后台线程
{
    internal class Student
    {
        public int Age { set; get; }
        public string Name { set; get; }

        public Student(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public Student()
        {
        }
    }
}