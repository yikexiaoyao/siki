using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_利用委托升级冒泡排序
{
    internal class Employee
    {
        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public string Name { private set; get; }

        public double Salary { private set; get; }

        public static bool Compare(Employee e1, Employee e2)
        {
            return e1.Salary > e2.Salary;
        }
    }
}