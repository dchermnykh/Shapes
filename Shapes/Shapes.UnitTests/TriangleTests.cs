using System;
using NUnit.Framework;
using Shapes.Extensions;
using Shapes.Implementation;

namespace Shapes.UnitTests
{
    class TriangleTests
    {
        [TestCase(-0.001, 10, 10)]
        [TestCase(-0.001, -0.001, 10)]
        [TestCase(-0.001, -0.001, -0.001)]
        [TestCase(10, -0.001, 10)]
        [TestCase(10, -0.001, -0.001)]
        [TestCase(10, 10, -0.001)]
        [TestCase(0, 10, 10)]
        [TestCase(10, 0, 10)]
        [TestCase(10, 10, 0)]
        [TestCase(2, 2, 10)]
        [TestCase(10, 2, 2)]
        [TestCase(2, 10, 2)]
        public void ExceptionTest(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var triangle = new Triangle(a, b, c);
            });
        }

        [TestCase(6, 10, 8, 24)]
        [TestCase(6, 8, 10, 24)]
        [TestCase(10, 8, 6, 24)]
        [TestCase(10, 6, 8, 24)]
        [TestCase(8, 10, 6, 24)]
        [TestCase(8, 6, 10, 24)]
        [TestCase(3, 4, 5, 6)]
        public void AreaTest(double a, double b, double c, double result)
        {
            var trianle = new Triangle(a, b, c);
            Helper.AssertShapeArea(trianle, result);
        }

        [TestCase(6, 10, 8, true)]
        [TestCase(6, 8, 10, true)]
        [TestCase(10, 8, 6, true)]
        [TestCase(10, 6, 8, true)]
        [TestCase(8, 10, 6, true)]
        [TestCase(8, 6, 10, true)]
        [TestCase(8, 8, 8, false)]
        [TestCase(6, 7, 8, false)]
        [TestCase(4, 4, 2, false)]
        public void IsSquareTriangleTest(double a, double b, double c, bool result)
        {
            var trianle = new Triangle(a, b, c);
            Assert.AreEqual(trianle.IsSquare(), result);
        }
    }
}
