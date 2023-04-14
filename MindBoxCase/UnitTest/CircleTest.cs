using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void SquareCheck()
        {
            Shapes.Circle c = new Shapes.Circle(1);
            Assert.AreEqual(2 * Math.PI, c.Square());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Bad argument for radius")]
        public void ArgCheck()
        {
            Shapes.Circle c = new Shapes.Circle(-1);
        }
    }
}
