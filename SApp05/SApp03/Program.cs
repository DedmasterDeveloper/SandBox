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

        struct User
        {
            public string Name;
            public int count;
        }


        static void Main(string[] args)
        {
            var message = "За окном потоп, а я ем торт.";

                PrintWorlds(message);


            StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "UsersList.txt");

            var users = new User[100];
            var userCount = int.Parse(sr.ReadLine());
            for(int i = 0; i < userCount; i++)
            {
                var user = sr.ReadLine();
                var fi = user.Split(' ');
                var counter = 1;
                for(int j = 0; j < i; j++)
                {
                    if (fi[0] == users[j].Name)
                        counter++;
                }
                users[i].Name = fi[0];
                users[i].count = counter;
            }

            sr.Close();
            Console.Clear();

            for (int i = 0; i < userCount; i++)
                Console.WriteLine(string.Format("{0}{1}", users[i].Name, users[i].count > 1 ? users[i].count.ToString() : string.Empty));

            Console.ReadKey();
        }
    }
}
