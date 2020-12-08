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

            Swap(ref a, ref b);

            Console.WriteLine($"{a} ; {b}");
            bool f;
            int c = new int();
            do
            {
                Console.Write("Введите число: ");
                //Проверка на тип данных
                f = int.TryParse(Console.ReadLine(), out c);
            }
            while (!f);

            Console.WriteLine($"Ваше числол: {c}");

            Console.ReadLine();
        }

        static void Swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }

        static void ChangeSign(ref int a, int b)
        {
            a = -a;
            b = -b;
        }
    }
}
