using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp02
{
    /*
     * Работаем с файловой системой 
     */
    class Program
    {
        static void PrintDir(DirectoryInfo dir, string indent, bool lastDirectory)
        {
            Console.Write(indent);
            if(lastDirectory)
            {
                Console.Write("└─");
                indent += "  "; 
            }
            else
            {
                Console.Write("├─");
                indent += "│";
            }

            Console.WriteLine($"{dir.Name}");

            DirectoryInfo[] subDirs = dir.GetDirectories();
            for(int i =0; i < subDirs.Length; i++)
            {
                PrintDir(subDirs[i], indent, i == subDirs.Length - 1);
            }
        }



        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);

            Console.WriteLine("FileName: {0}", di.FullName);
            Console.WriteLine("Attributes: {0}", di.Attributes.ToString());
            Console.WriteLine("CreationTime: {0}", di.CreationTime);

            Console.Clear();

            PrintDir(new DirectoryInfo(@"D:\Steam"), string.Empty, true);

            Console.WriteLine("Для закрытия нажмите Enter");
            Console.ReadKey();
        }
    }
}
