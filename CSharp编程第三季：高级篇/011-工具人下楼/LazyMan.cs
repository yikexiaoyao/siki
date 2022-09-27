using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_工具人下楼
{
    internal class LazyMan
    {
        public LazyMan(string name)
        {
            Name = name;
        }

        public string Name { private set; get; }

        public void TakeFood()
        {
            Console.WriteLine("给" + Name + "拿外卖");
        }

        public void TakePackage()
        {
            Console.WriteLine("给" + Name + "拿快递");
        }
    }
}