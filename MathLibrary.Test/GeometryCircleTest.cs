using System;
using NUnit.Framework;

namespace MathLibrary.GeometryCircleTest
{
    [TestFixture]
    public class GeometryCircleTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(new double[] { 0.0, 0.0 }, new double[] { 1.0, 0.0 }, Math.PI)]
        [TestCase(new double[] { 0.0, 0.0 }, new double[] { 0.0, 0.0 }, 0.0)]
        [TestCase(new double[] { 0.0, 0.0 }, new double[] { -1.0, 0.0 }, Math.PI)]
        public void AreaCircleTest(double[] vectorStart, double[] vectorEnd, double expected)
        {
            var segment = new Segment(new Vector(vectorStart[0], vectorStart[1])
                , new Vector(vectorEnd[0], vectorEnd[1]));
            var actual = segment.GetAreaCircle();

            Assert.AreEqual(expected, actual);
        }

        /// The db has tables Products and Categorys
        ///SELECT Products.Name, Category.name
        ///FROM Products 
        ///FULL OUTER JOIN Category ON Products.ProductsID=Category.ProductsID
        ///ORDER BY Products.Name;

    }
}
