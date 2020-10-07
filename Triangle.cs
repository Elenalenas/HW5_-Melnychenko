using System;
using System.Collections.Generic;
using System.Text;

namespace HW5__Melnychenko
{
    internal class Triangle : Shape
    {
        private double Area;
        private readonly int Side;
      
        public Triangle(int side, string name = "Triangle") : base(name)
        {
            Side = side;
           
        }

        public override void GetArea()
        {
            try
            {
                if ((Side <= 0))
                {
                    Area = Side * 3;
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
}
