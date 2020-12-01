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
            double a = 1;
            double b = 2;
            double c = 1;
            double x = new double();

            Console.Write("Введите число X: ");
            string s = Console.ReadLine();
            x = Convert.ToDouble(s);

            var f = Math.Pow(x,2) + b *x + c;
            Console.WriteLine($"{a} * {x}^2 + {b} * {x} + {c} = {f}");
            Console.WriteLine("Нажмите Enter для закрытия");
            Console.ReadLine();
        }
    }
}
