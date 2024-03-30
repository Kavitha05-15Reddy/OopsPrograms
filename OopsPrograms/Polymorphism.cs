using System;

namespace OopsPrograms
{
    abstract class Shape
    {
        public abstract void CalculateArea();
    }
    class Circle : Shape
    {
        double radius = 5;
        public override void CalculateArea()
        {
            Console.WriteLine("Area of Circle: " + Math.PI * radius * radius);
        }
    }
    class Rectangle : Shape
    {
        double length = 5.5;
        double width = 5;
        public override void CalculateArea()
        {
            Console.WriteLine("Area of Rectangle: " + length * width);
        }
    }
    class Triangle : Shape
    {
        double b = 3.4;
        double h = 5;
        public override void CalculateArea()
        {
            Console.WriteLine("Area of Triangle: " + ( b * h ) / 2);
        }
    }
}
