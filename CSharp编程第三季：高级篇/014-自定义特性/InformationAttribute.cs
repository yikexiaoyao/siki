using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_自定义特性
{
    [AttributeUsage(AttributeTargets.Class)]
    internal sealed class InformationAttribute : Attribute
    {
        public string description;
        public string developer;
        public string version;

        public InformationAttribute(string developer, string version, string description)
        {
            this.developer = developer;
            this.version = version;
            this.description = description;
        }
    }
}