using System;

namespace Shapes.Implementation
{
    public sealed class Circle : IShape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Circle radius can't be less than  0");
            }

            Radius = radius;
        }


        public double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
