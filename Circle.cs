using System;
using System.Collections.Generic;
using System.Text;

namespace HW5__Melnychenko
{
    internal class Circle : Shape
    {
        public string GetName => "Circle2";
        public override void GetArea()
        {
            Console.WriteLine("Area is 20");
        }
    }
}
