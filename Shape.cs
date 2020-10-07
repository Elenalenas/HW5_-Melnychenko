using System;
using System.Dynamic;

namespace HW5__Melnychenko
{
    public abstract class Shape
    {
        public string Name; 
        public Shape(string name)
        {
            Name = name;
         }
        public void GetName()
        {
            Console.WriteLine($"Фигура - {Name}");
        }

        public abstract void GetArea();
    }
}
