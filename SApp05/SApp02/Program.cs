using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp02
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1;
            s1 = "abs";
            string s2 = "";
            string s3 = string.Empty;

            var s4 = @"Hellow world! 
   Hello Home";
            Console.WriteLine(s4);
            var s5 = "C:\\Windows\\ABC\\text.txt";
            var s6 = @"C:\Windows\ABC\text.txt";

            string s7 = new string('a', 10);

            string _s1 = "Simple";
            string _s2 = "SimplE";

            Console.WriteLine($"_s1 vs _s2 : {_s2.CompareTo(_s1)}");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
