using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csl_1
{
    class StringValueAttribute:Attribute
    {
        public string Value;
        public StringValueAttribute(string value)
        {
            Value = value;
        }
    }
    class DayAttribute:Attribute
    {
        public string Name { get; private set; }
        public DayAttribute(string name)
        {
            this.Name = name;
        }
    }
}
