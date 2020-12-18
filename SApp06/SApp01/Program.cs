using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp01
{
    /*
     * Проходим делегаты
     */

    delegate double DoOperation(double x, double y);

    class Program
    {
        public static void Process(DoOperation operation, double x, double y)
        {
            var res = operation(x, y);
            Console.WriteLine($" = {res}");
            Console.WriteLine();
        }

        public static double Plus(double x, double y)
        {
            Console.Write($"{x} + {y}");
            return x + y;
        }

        public static double Minus(double x, double y)
        {
            Console.Write($"{x} - {y}");
            return x - y;
        }


        static void Main(string[] args)
        {
            Process(Plus, 10, 5);
            Process(Minus, 7, 5);


            DoOperation multiOperation = delegate (double x, double y)
            {
                Console.Write($"{x} * {y}");
                return x * y;
            };

            Console.WriteLine($" = {multiOperation(5,5)}");
            Console.WriteLine();


            Console.ReadLine();
        }
    }
}
