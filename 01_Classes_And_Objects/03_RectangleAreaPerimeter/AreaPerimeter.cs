using System;
using System.Collections.Generic;
using System.Text;

namespace _03_RectangleAreaPerimeter
{
    internal class Rectangle
    {
        private double Length;
        private double Width;

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;

        }

        public void CalculateArea()
        {
            Console.WriteLine($"Area = {Length * Width}");
        }
        public void CalculatePerimeter()
        {
            Console.WriteLine($"Perimeter = {2 * (Length + Width)}");
        }

    }
}
