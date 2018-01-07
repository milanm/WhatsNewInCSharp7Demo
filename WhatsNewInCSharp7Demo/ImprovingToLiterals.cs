using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsNewInCSharp7Demo
{
    class ImprovingToLiterals
    {
        // Binary
        public const int Sixteen = 0b0001_0000;
        public const int ThirtyTwo = 0b0010_0000;
        public const int SixtyFour = 0b0100_0000;
        public const int OneHundredTwentyEight = 0b1000_0000;

        // C# 7.2
        public const int binaryValue = 0b_0101_0101; // _ leading character

        // Decimal
        public const long BillionsAndBillions = 100_000_000_000;
    }
}
