using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp03
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo fInfo = new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "Test.txt");

            if (fInfo.Exists)
            {
                Console.WriteLine($"FullName: {fInfo.FullName}");
                Console.WriteLine($"FileLength: {fInfo.Length}");
            }

            using (var reader = fInfo.OpenText())
            {
                while(!reader.EndOfStream)
                {
                    Console.WriteLine(reader.ReadLine());
                }
            }

            Console.WriteLine();

            using(var writer = fInfo.AppendText()) //StreamWriter
            {
                writer.WriteLine("\nА вот и сново я\nя вернулся");
            }

            using (var reader = fInfo.OpenText()) //StreamReader
            {
                while (!reader.EndOfStream)
                {
                    Console.WriteLine(reader.ReadLine());
                }
            }
            Console.ReadLine();
        }
    }
}
