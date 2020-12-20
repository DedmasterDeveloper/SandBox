using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp04
{
    class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public DateTime Birthday { get; set; }

        class Program
        {
            static void Main(string[] args)
            {
                ArrayList users = new ArrayList();
                using (var reader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "usersList.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] userString = reader.ReadLine().Split(' ');
                        var user = new User() 
                        { 
                          Surname = userString[0], 
                          Name = userString[1], 
                          Birthday = Convert.ToDateTime(userString[2]) 
                        };
                        users.Add(user);
                    }
                }

                foreach (var user in users)
                {
                    if(user is User)
                    {
                        Console.WriteLine($"{((User)user).Surname} {((User)user).Name} {((User)user).Birthday.ToShortDateString()}");
                    }
                }

                Console.WriteLine();

                List<User> users2 = new List<User>();

                using (var reader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "usersList.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] userString = reader.ReadLine().Split(' ');
                        var user = new User()
                        {
                            Surname = userString[0],
                            Name = userString[1],
                            Birthday = Convert.ToDateTime(userString[2])
                        };
                        users2.Add(user);
                    }
                }

                foreach (var user in users2)
                {
                    Console.WriteLine($"{user.Surname} {user.Name} {user.Birthday.ToShortDateString()}");
                }

                Dictionary<int, User> dict = new Dictionary<int, User>();

                var counter = 1;
                using (var reader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "usersList.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] userString = reader.ReadLine().Split(' ');
                        var user = new User()
                        {
                            Surname = userString[0],
                            Name = userString[1],
                            Birthday = Convert.ToDateTime(userString[2])
                        };
                        
                        if(dict.ContainsKey(counter))
                        {
                            counter++;
                        }

                        dict.Add(counter, user);
                    }
                }


                Console.Read();
            }
        }
    }
}
