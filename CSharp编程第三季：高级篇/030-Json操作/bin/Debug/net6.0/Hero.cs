using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030_Json操作
{
    internal class Hero
    {
        public string name { set; get; }
        public int maxHP { set; get; }
        public string type { set; get; }
        public List<Skill> skillList { set; get; }
    }
}