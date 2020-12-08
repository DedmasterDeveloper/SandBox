using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp04
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12;
            int b = 1;

            ChangeSign(ref a, b);

            Console.WriteLine($"{a} ; {b}");
            Console.ReadLine();
        }

        static void ChangeSign(ref int a, int b)
        {
            a = -a;
            b = -b;
        }
    }
}
