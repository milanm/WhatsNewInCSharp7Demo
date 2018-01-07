using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsNewInCSharp7Demo
{
    class ThrowExceptions
    {
        public int Method()
        {
            throw new NotImplementedException(); // Quick action: use exp.body
        }

        public static void Bar(string s) => Test(s ?? throw new ArgumentNullException(nameof(s)));
        //{
        //    //if (s == null)
        //    //    throw new ArgumentNullException(nameof(s));

        //    Test(s ?? throw new ArgumentNullException(nameof(s)));
        //}

        string name;
        public string Name
        {
            get => name;
            set => name = value ??
                throw new ArgumentNullException(paramName: nameof(value), message: "New name must not be null");
        }

        private static void Test(string s)
        {
            // code
        }

        static void Main(string[] args)
        {
            Bar("test");
        }
    }
}
