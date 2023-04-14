using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void SquareCheck()
        {
            Shapes.Triangle t = new Shapes.Triangle(3, 5, 4);
            Assert.AreEqual(6, t.Square());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Bad argument for side")]
        public void ArgCheck()
        {
            Shapes.Triangle t = new Shapes.Triangle(-1, 1, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Triangle does not exist")]
        public void TriangleExists()
        {
            Shapes.Triangle t = new Shapes.Triangle(1, 1, 5);
        }
    }
}
