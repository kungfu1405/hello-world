using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Csl_1
{
    class StringClass
    {
        public StringClass()
        {

        }
    }
    class Genneric_one<T>
    {
        private T gennericField;

        public T GennericProperty { get => gennericField; set => gennericField = value; }
        public T GennericMethod(T gennricPara)
        {
            this.gennericField = gennricPara;
            return this.gennericField;
        }
    }
    class Genneric_struct<T> where T :struct
    {
        private T gennericField;

        public T GennericProperty { get => gennericField; set => gennericField = value; }
        public T GennericMethod(T gennricPara)
        {
            this.gennericField = gennricPara;
            return this.gennericField;
        }
    }
    class Generic_Class<T> where T : class
    {
        private T gennericField;

        public T GennericProperty { get => gennericField; set => gennericField = value; }
        public T GennericMethod(T gennricPara)
        {
            this.gennericField = gennricPara;
            return this.gennericField;
        }
    }
    class Generic_Constructor<T> where T : new()
    {
        //TODO:
    }
    interface IPerson
    {
        public void MethodPerson();
    }
    class Studen : IPerson { 
    public void MethodPerson() { }
    }
    class Employee :Studen{ }
    class Generic_Interface<T> where T : IPerson 
    {
        private T genericField;
        public  Generic_Interface(T paramater)
        {
            this.genericField = paramater;
            //return this.genericField;
        }
        public T GenericProperty { get => genericField; set => genericField = value; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Employee em1 = new Employee();
            //Generic_Interface<Employee> generic_Interface = new Generic_Interface<Employee>(em1);
            //Employee e = generic_Interface.GenericProperty;
            //e.MethodPerson();

            Season a = (Season)0; // Season.Autumn;
            Type type = a.GetType();
            var a_prop = type.GetProperty("Spring");

            MyClass myClass = new MyClass();
            Type myGenericclassType = typeof(MyClass);// myClass.GetType(); 

            var genericPro = myGenericclassType.GetProperty("MyField");

            var genericField = myGenericclassType.GetField("_myField");
            var genericFields = myGenericclassType.GetFields();

            string a_name = genericFields[0].Name;

            var fields = a.GetType().GetField(a.ToString());    
            StringValue[] stringValue = fields.GetCustomAttributes(typeof(StringValue), false) as StringValue[];
            //var value = stringValue.FirstOrDefault();
            //Console.WriteLine(typeof(b));


            ProBs.NameMonth(1);
            Console.ReadLine();

        }

    }
    class ProBs
    {
        public static void  NameMonth(int month)
        {            
            Month thisMonth = (Month)month;

            
            Console.WriteLine(GetEnumDescription(thisMonth));
            Console.ReadLine();
        }
        public static string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes = fi.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];
            //DayAttribute[] attributes = fi.GetCustomAttributes(typeof(DayAttribute), false) as DayAttribute[];

            if (attributes != null && attributes.Any())
            {
                return attributes.First().Description;
            }
            return value.ToString();
        }
    }
    enum Month
    {   [DescriptionAttribute("Thang 1")]
        January =1,
        [DescriptionAttribute("Thang 2")]
        Feb = 2 ,
        [DescriptionAttribute("Thang 3")]
        March = 3,
        [DescriptionAttribute("Thang 4")]
        April = 4,
        [DescriptionAttribute("Thang 5")]
        May = 5,
        June = 6,
        July = 7,
        August = 8,
        September = 9,
        October = 10,
        November = 11,
        December = 12,
    }
    public enum Season
    {
        [StringValue("Mua xuan")]
        Spring,
        [Description("Mùa hè")]
        Summer,
        Autumn,
        Winter
    }
    class MyGenericclass<T>
    {
        private T _myField;

        public T MyField { get => _myField; set => _myField = value; }
        public void MyMethod() { }
    }
    class MyClass
    {
        public string _myField;

        public string MyField { get => _myField; set => _myField = value; }
        public void MyMethod() { }
    }
}
