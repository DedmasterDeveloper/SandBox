using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp07
{
    class MyClass
    {
        int[] _a;

        public MyClass(int[] a)
        {
            _a = a;
        }

        public int[] A
        {
            get { return _a; }
        }

        public int this[int i]
        {
            get
            {
                return _a[i];
            }
            set
            {
                _a[i] = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3, 3];
            int[,] a2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 4, 2, 1 } };

            int x = 3;
            int y = 3;

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write($"{ a2[i, j]}  ");

                }
                Console.WriteLine();
            }

            int[][] stepArray = new int[3][];
            stepArray[0] = new int[3] { 1, 2, 3 };
            stepArray[1] = new int[5] { 1, 2, 3, 19, 12 };
            stepArray[2] = new int[1] { 0 };


            Console.WriteLine();
            int[] a3 = { 1, 2, 3, 4 };
            MyClass myClass = new MyClass(a3);
            var e = myClass[1];
            myClass[2] = 19;
            Console.WriteLine(e);
            Console.WriteLine(myClass[2]);
            Console.ReadLine();
        }
    }
}
