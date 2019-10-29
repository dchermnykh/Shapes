using System;
using NUnit.Framework;
using Shapes.Implementation;

namespace Shapes.UnitTests
{
    class CircleTests
    {
        [TestCase(1, 3.141593)]
        [TestCase(2, 12.566371)]
        public void AreaTest(double radius, double result)
        {
            var circle = new Circle(radius);
            Helper.AssertShapeArea(circle, result);
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void CreateExceptionTest(double radius)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var circle = new Circle(radius);
            });
        }
    }
}
