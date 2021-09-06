using NUnit.Framework;
using MathLibrary;

namespace MathLibraryTest
{
    [TestFixture]
    public class GeometryTest
    {
        [TestCase(new double[] { 15.0, 15.0, 23.0, 30.0, 50.0, 25.0 }, 222.50)]
        [TestCase(new double[] { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 }, 0.0)]
        [TestCase(new double[] { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 }, 0.0)]
        public void GetAreaTriangleTest(double[] input, double expected)
        {
            var a = new Vector(input[0], input[1]);
            var b = new Vector(input[2], input[3]);
            var c = new Vector(input[4], input[5]);

            var actual = Geometry.GetAreaTriangle(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new double[] { 15.0, 15.0, 23.0, 30.0, 50.0, 25.0 }, false)]
        [TestCase(new double[] { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 }, true)]
        [TestCase(new double[] { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 }, true)]
        public void CheckRightAngleTest(double[] input, bool expected)
        {
            var a = new Vector(input[0], input[1]);
            var b = new Vector(input[2], input[3]);
            var c = new Vector(input[4], input[5]);

            var actual = Geometry.GetAreaTriangle(a, b, c);

            Assert.AreEqual(expected, actual);
        }
    }
}
