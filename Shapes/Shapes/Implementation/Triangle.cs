using System;

namespace Shapes.Implementation
{
    public sealed class Triangle : IShape
    {
        public double A { get; }

        public double B { get; }

        public double C { get; }

        public Triangle(double a, double b, double c)
        {
            Validate(a, b, c);
            A = a;
            B = b;
            C = c;
        }

        public double Area()
        {
            return GetAreaByGeron(A, B, C);
        }

        private static double GetAreaByGeron(double a, double b, double c)
        {
            var perimeter = a + b + c;
            var halfPerimeter = perimeter / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
        }

        private static void Validate(double a, double b, double c)
        {
            if (a + b < c ||
                b + c < a ||
                a + c < b)
            {
                throw new ArgumentException("Can't create triangle: sum of 2 sides less than third side");
            }

            if (a <= 0 ||
                b <= 0 ||
                c <= 0)
            {
                throw new ArgumentException("Triangle side can't be less than 0");
            }
        }
    }
}
