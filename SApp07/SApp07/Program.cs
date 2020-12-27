using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SApp07
{
    public class MyClass
    {
        private int _myField;

        public int MyProperty
        {
            get { return _myField; }
            set { _myField = value; }
        }
    }

    class Program
    {
        static PropertyInfo GetPropertyInfo(object o, string propertyName)
        {
            return o.GetType().GetProperty(propertyName);
        }


        static void Main(string[] args)
        {
            Type type01 = typeof(MyClass);
            Console.WriteLine(type01.ToString());

            var myClass = new MyClass();
            myClass.MyProperty = 11;

            Type type02 = myClass.GetType();

            Console.WriteLine(type02.ToString());

            var propertyInfo =  GetPropertyInfo(myClass, "MyProperty");

            if(propertyInfo.CanRead)
            {
               var value =  propertyInfo.GetValue(myClass);
                Console.WriteLine($"MyClass => {myClass.GetType()} => MyProperty: {value}");
            }

            if (propertyInfo.CanWrite)
            {
                propertyInfo.SetValue(myClass, 101);
                Console.WriteLine($"MyClass => {myClass.GetType()} => MyProperty: {propertyInfo.GetValue(myClass)}");
            }


            Console.ReadLine();
        }
    }
}
