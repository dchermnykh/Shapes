using System;
using NUnit.Framework;

namespace Shapes.UnitTests
{
    public static class Helper
    {
        private const double Tolerance = 0.00001;

        public static void AssertShapeArea(IShape shape, double areaResult)
        {
            var area = shape.Area();
            Assert.IsTrue(Math.Abs(area - areaResult) < Tolerance);
        }
    }
}
