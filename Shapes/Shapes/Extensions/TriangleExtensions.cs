using Shapes.Implementation;

namespace Shapes.Extensions
{
    public static class TriangleExtensions
    {
        public static bool IsSquare(this Triangle triangle)
        {
            return IsHypotenuse(triangle.A, triangle.B, triangle.C) ||
                   IsHypotenuse(triangle.B, triangle.A, triangle.C) ||
                   IsHypotenuse(triangle.C, triangle.A, triangle.B);
        }

        private static bool IsHypotenuse(double a, double b, double c)
        {
            return (a * a).Equals(b * b + c * c);
        }
    }
}
