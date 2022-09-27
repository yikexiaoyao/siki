using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_工具人下楼
{
    internal delegate void DownStairDelegate();

    internal class ToolMan
    {
        //受限委托
        public event DownStairDelegate downStairDelegate = null;

        public ToolMan(string name)
        {
            Name = name;
        }

        public string Name { private set; get; }

        public void DownStair()
        {
            Console.WriteLine("工具人" + Name + "下楼了");
            if (downStairDelegate != null)
            {
                downStairDelegate();
            }
        }
    }
}