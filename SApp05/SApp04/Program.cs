using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SApp04
{
    struct Element
    {
        public string Tag;
        public string Str;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Regex myReg = new Regex(@"[A-Za-z]");
            Console.WriteLine(myReg.IsMatch("Hello!"));
            


            myReg = new Regex(@"[A-Za-z]{5,7}");
            Console.WriteLine(myReg.IsMatch("Hello!"));
            Console.WriteLine(myReg.IsMatch("Привет!"));

            var template = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "Template.txt");
            Element[] elements = new Element[8]
            {
                new Element ("name1", "Есикова М.А."),
                new Element("name2", "Прошу взять меня на работу ")
            };

            foreach(var element in elements)
            {
                Regex regex = new Regex("<" + element.Tag + ">");
                template =  regex.Replace(template, element.Str);
            }
            Console.Clear();
            Console.WriteLine(template);

            Console.ReadKey();
        }
    }
}
