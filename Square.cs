using System;
using System.Collections.Generic;
using System.Text;

namespace HW5__Melnychenko
{
    internal class Square : Shape
    {
        private double Area;
        private readonly int Height;
        public Square(int height, string name = "Square") : base(name)
        {
            int Height = height;
        }

        public override void GetArea()
        {
            try
            {
                if (Height <= 0)
                {
                    Area = Height * 4;
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