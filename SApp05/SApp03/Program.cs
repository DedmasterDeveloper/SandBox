using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp03
{
    class Program
    {
        private static string[] separators = { ",", ".", "!", "?", ";", ":", " "};

        static void PrintWorlds(string message)
        {
            //Возвращает мссив строк
            var worlds = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int i = 0;
            foreach(string str in worlds)
            {
                if(str.Length >= 3 && str[0].Equals(str[str.Length-1]) )
                {
                    Console.WriteLine($"{str}");
                }
            }
        }

        static void Main(string[] args)
        {
            var message = "За окном потоп, а я ем торт.";

                PrintWorlds(message);

            Console.ReadKey();
        }
    }
}
