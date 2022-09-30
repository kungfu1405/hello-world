using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csl_1
{
    class StringValue:Attribute
    {
        public string Value;
        public StringValue(string value)
        {
            Value = value;
        }
    }
}
