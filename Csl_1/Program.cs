using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using XmSource;
namespace Csl_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ThisMonth(3);
            //Console.ReadLine();
            string n1 = "11", n2 = "44";

            string lesster = Convert.ToInt16(n1) < Convert.ToInt16(n2) ? n1 : n2;
        }
        public static void ThisMonth(int month)
        {
            Month thisMonth = (Month)month;
            Console.WriteLine(XmReflect.GetEnumDescription(thisMonth));            
        }
    }
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

        //public static string GetEnumDescription(this Enum enumValue)
        //{
        //    var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());

        //    var descriptionAttributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

        //    return descriptionAttributes.Length > 0 ? descriptionAttributes[0].Description : enumValue.ToString();
        //}
    }
    enum Month
    {   [Description("Thang 1")]
        January =1,
        [Description("Thang 2")]
        Feb = 2 ,
        [Description("Thang 3")]
        March = 3,
        [Description("Thang 4")]
        April = 4,
        [Description("Thang 5")]
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
        [Description("Mua xuan")]
        Spring,
        [Description("Mùa hè")]
        Summer,
        [StringValue("Maf thu")]
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
