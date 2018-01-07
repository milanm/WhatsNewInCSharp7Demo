using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsNewInCSharp7Demo
{
    class PatternMatching
    {
        static void Main(string[] args)
        {
            // 1. Out variables
            if (int.TryParse("500", out var quantity))
                Console.WriteLine(quantity);
            else
                Console.WriteLine("Quantity is not a valid integer!");

            Console.WriteLine($"{nameof(quantity)}: {quantity}");

            // 2. Pattern matching - type pattern
            if (int.TryParse("500", out var quantity1) && quantity1 is int x)
                Console.WriteLine($"Quanitty is {x}");
            else
                Console.WriteLine("Quantity is not a valid integer!");

            // 3. Pattern matching - const pattern
            object o = 5;
            IsPattern(o);

            // 4. Switch
            switch (o)
            {
                case null:
                    Console.WriteLine("It was null! Help! ;");
                    break;
                case int y:
                    Console.Write(y);
                    break;
                case string s when s.Length > 0:
                    Console.WriteLine(s);
                    break;
                //case Person p when p.FirstName.StartsWith(“Ge"):
                //    Console.WriteLine($"a Ge person {p.FirstName}");
                //    break;
            }


            Console.ReadLine();
        }

        public static void IsPattern(object o)
        {
            if (o is null) throw new ArgumentNullException(nameof(o));
        }

    }
}
