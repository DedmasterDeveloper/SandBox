using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp01
{
    class Program
    {
        static void Main(string[] args)
        {
            var chars = new[]
            {
                'j',
                '\u006A',
                '\x006A',
                (char)106
            };

            Console.WriteLine(string.Join("\t",chars));

            char b = 'B';

            Console.WriteLine($"{b} {Char.ToLower(b)} {char.GetNumericValue(b)}");

            var a = new char[] {'1', 's', '$', 'M' };
            for(int i = 0; i < a.Length; i++)
            {
                var category = char.GetUnicodeCategory(a[i]);
                switch (category)
                {
                    case System.Globalization.UnicodeCategory.UppercaseLetter:
                        Console.WriteLine($"{a[i]} - буква верхнего регистра");
                        break;
                    case System.Globalization.UnicodeCategory.LowercaseLetter:
                        Console.WriteLine($"{a[i]} - буква нижнего регистра");
                        break;
                    case System.Globalization.UnicodeCategory.DecimalDigitNumber:
                        Console.WriteLine($"{a[i]} - символ является числом");
                        break;
                    default:
                        Console.WriteLine("Другое...");
                        break;
                }
            }

            Console.WriteLine();
            char[] d = "Преобразуем строку в массив символов".ToCharArray();

            for(int i = 0; i < d.Length; i++)
            {
                if (Char.IsLower(d[i]))
                    d[i] = char.ToUpper(d[i]);
                Console.WriteLine($"{d[i]}");
            }
            Console.ReadKey();
        }
    }
}
