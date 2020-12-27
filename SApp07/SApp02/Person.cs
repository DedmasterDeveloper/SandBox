using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp02
{
    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string SeccondName { get; set; }

        public int Age { get; set; }

        public Person() { }

        public Person(string lastName, String firstName, string secondName, int age)
        {
            LastName = lastName;
            FirstName = firstName;
            SeccondName = secondName;
            Age = age;
        }
    }
}
