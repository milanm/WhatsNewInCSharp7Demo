using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsNewInCSharp7Demo
{
    class Tuples
    {
        static void Main(string[] args)
        {
            // 1. Tuple type (pass by reference)
            Tuple<string, int> info = GetStudent("1110-836");
            Console.WriteLine($"Name: {info.Item1}, Age: {info.Item2}");

            // 2. Value Tuple (pass by value)
            (string name, int _) student = GetStudentValue("1110-836");
            var studentName = student.name;

            // 3. Value Tuple Deconstruction into variables
            var (name, age) = GetStudentValue("150 - 800");
            Console.WriteLine($"Name: {name}, Age: {age}");

            // 4. C# 7.1
            int x = 1;
            int y = 2;
            var t = (x, y);
            int getX = t.x; // didn't compile on C# 7.0

            // 5. Compound key for dictionary
            var dictionary = new Dictionary<(int, int), string>();
            dictionary[(1, 2)] = "SomeValue";
            var retrieve = dictionary[(1, 2)];
            Console.WriteLine(retrieve);

            Console.ReadLine();
        }

        public static Tuple<string, int> GetStudent(string id)
        {
            return new Tuple<string, int>("Mike", 19);
        }

        static (string name, int age) GetStudentValue(string id)
        {
            return (name: "Mike", age: 19);
        }


    }
}
