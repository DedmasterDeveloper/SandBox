using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp09
{
    class Program
    {
        public static int[] LoadArrayFromFileV1(string fileName)
        {
            if (File.Exists(fileName))
            {
                StreamReader reader = new StreamReader(fileName);
                var str =  reader.ReadLine();
                int.TryParse(str, out int len);

                var arr = new int[len];

                for(int i = 0; i < len; i++)
                {
                    if(int.TryParse(reader.ReadLine(), out int num))
                    {
                        arr[i] = num;
                    }
                }

                return arr; 
                
            }
            else
                throw new Exception("Файл не найден");
        }

        static void Main(string[] args)
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory + "ArrayList.txt";
            var arr = LoadArrayFromFileV1(dir);
            
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
