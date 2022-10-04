using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;

namespace Csl_1
{
    public class RetrievingInformation
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");

        //    int i = ExampleAttribute.Add(2, 3);

        //}
        
        static void GetAttribute(Type t)
        {

        }
    }
    class ExampleAttribute
    {
        [Obsolete("will removed in next version")]
        public static int Add(int a , int b)
        {
            return (a + b);
        }
        //[Property] looi
        private string _myField;

        [Property]
        public int MyProperty { get; set; }

    }

    [AttributeUsage(AttributeTargets.Method ,Inherited = false)]
    class MethodAttribute :Attribute
    {

    }
    [AttributeUsage(AttributeTargets.Property,Inherited =false)]
    class PropertyAttribute :Attribute
    {

    }
}
