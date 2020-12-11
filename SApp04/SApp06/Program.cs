using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp06
{
    class Complex
    {
        private double _re;
        private double _im;

        


        public override string ToString()
        {
            return $"{_re} + {_im}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyClass myClass1 = new MyClass();
            MyClass myClass2 = myClass;
            Console.WriteLine($"myClass равен myClass1 ? Ответ: {myClass.Equals(myClass1)}" );
            Console.WriteLine($"myClass равен myClass2 ? Ответ: {myClass.Equals(myClass2)}");
            Console.ReadLine();
        }
    }
}
