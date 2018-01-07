using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsNewInCSharp7Demo
{
    class ExpressionBodiedMethodsAndProps
    {
        // Expression-bodied methods and properties -> contrib from community in Roslyn
        class Circle
        {
            public Circle(double radius) => Radius = radius;

            public double Radius { get; }

            public double Sourface => Radius * Radius * Math.PI;
            //{
            //    get
            //    {
            //        return Radius * Radius * Math.PI;
            //    }
            //}

            public int X
            {
                get => 42;
                set => throw new NotImplementedException(); // expr.

            }
        }
        static void Main(string[] args)
        {

        }
    }
}
