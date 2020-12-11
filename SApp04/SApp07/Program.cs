using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3, 3];
            int[,] a2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 4, 2, 1 } };

            int x = 3;
            int y = 3;

            for(int i =0; i < x; i++)
            {
                for(int j = 0; j < y; j++)
                {
                    Console.WriteLine($"{ a2[i, j]}");
                    
                }
            }
            

            Console.ReadLine();
        }
    }
}
