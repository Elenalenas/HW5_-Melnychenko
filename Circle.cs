using System;
using System.Collections.Generic;
using System.Text;

namespace HW5__Melnychenko
{
    class Circle : Shape
    {
        public override string GetName => "Circle";
        public override void GetArea()
        {
            Console.WriteLine("Area is 25");
        }
    }
}
