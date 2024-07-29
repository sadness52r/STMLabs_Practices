using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5_MySerializer
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class JsonNameAttribute : Attribute
    {
        private readonly string name;

        public string Name => name;

        public JsonNameAttribute(string name) 
        {
            this.name = name;
        }
    }
}
