using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsNewInCSharp7Demo
{
    class AsyncMain
    {
        static async Task Main(string[] args)
        {
            // asynchronous code

            // Default literals.
            var list = default(List<int>);
            List<int> dlist = default; // -> target typing

            int numeric = default;
            Object reference = default;
            DateTime value = default;
        }
    }
}
