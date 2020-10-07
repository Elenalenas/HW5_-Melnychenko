using System;
using System.Collections.Generic;
using System.Text;

namespace HW5__Melnychenko
{
    class Rectangle : Shape
    {
        private double Area;
        private readonly int Width;
        private readonly int Height;
        public Rectangle(int width, int height, string name = "Rectangle") : base(name)
        {
            Width = width;
            Height = height;
        }
            
            public override void GetArea()
        {
            try
            {
                if ((Width <= 0) || (Height <= 0))
                {
                    Area = Width * Height;
                    Console.WriteLine($"Площадь = {Area}");
                }

            }
            catch 
            {
                Console.WriteLine("Exception");
            }
        }
    }
}
