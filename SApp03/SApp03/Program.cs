using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp03
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.ferst();
        }

        public void ferst ()
        {
            Console.WriteLine("Введите 2 целыъ числа: ");
            Console.Write("Первое число: ");
            var b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Второе число: ");
            var c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Наибольшее число: {0}", b > c ? b : c);

            Console.WriteLine("Для выхода нажмите Enter");
            Console.ReadLine();
        }

        public void second()
        {
            int a = 45;

            switch(a)
            {
                case 1:
                    Console.WriteLine("a = 1");
                    break;
                case 2:
                    Console.WriteLine("a = 2");
                    break;
                case 3:
                    Console.WriteLine("a = 3");
                    break;
                default:
                    Console.WriteLine("Default Value...");
                    break;
            }
            Console.ReadLine();
        }
    }
}
