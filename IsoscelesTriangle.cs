using System;
using System.Collections.Generic;
using System.Text;

namespace HW5__Melnychenko
{
    class IsoscelesTriangle : Triangle
    {
        public override string GetName => "IsoscelesTriangle";
        public override void GetArea()
        {
            Console.WriteLine("Area is 125");
        }
    }
}
