using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp05
{
    class Program
    {
        struct Complex
        {   
            /// <summary>
            /// Действительная часть комплексного числа
            /// </summary>
            public double re;

            /// <summary>
            ///  Мнимая часть комплексного числа
            /// </summary>
            public double im;

            public override string ToString()
            {
                return $"{re} + {im}i";
            }

            public Complex Plus(Complex x)
            {
                Complex y;
                y.re = re + x.re;
                y.im = im + x.im;
                return y;
            }
        }



        static void Main(string[] args)
        {
            Complex complex1;
            complex1.re = -2;
            complex1.im = 5;
            Complex complex2;
            complex2.re = 10;
            complex2.im = 1;

            Console.WriteLine($"Работа с комплексными числами: {complex1} и {complex2}");
            Console.WriteLine($"Результат сложения комплексных чисел: {complex1.Plus(complex2)}");
            Console.ReadLine();
        }
    }
}
