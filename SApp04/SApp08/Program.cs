using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp08
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new[] { 100, 2, -5, 17, 6, 8 };

            for(int i = 0; i <a.Length; i++)
            { 
                Console.Write($"{a[i]} "); 
            }
            Console.WriteLine();

            Array.Sort(a);

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]} ");
            }
            Console.WriteLine();

            var num = 17;

            var index = Array.BinarySearch(a, num);

            Console.WriteLine($"Index = {index} ");

            Console.ReadKey();
        }
    }
}
