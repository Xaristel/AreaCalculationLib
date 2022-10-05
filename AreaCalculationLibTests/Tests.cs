using AreaCalculationLib;

namespace AreaCalculationLibTests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TestCircle()
        {
            Circle testCircle = new Circle(0);

            Assert.AreEqual(0, Math.Round(testCircle.GetArea(), 0));

            testCircle.R = 1;
            Assert.AreEqual(3.141593, Math.Round(testCircle.GetArea(), 6));

            testCircle.R = 2;
            Assert.AreEqual(12.566371, Math.Round(testCircle.GetArea(), 6));

            testCircle.R = 256;
            Assert.AreEqual(205887.41614, Math.Round(testCircle.GetArea(), 6));
        }

        [TestMethod]
        public void TestTriangle()
        {
            Triangle testTriangle = new Triangle(1, 1, 1);

            Assert.AreEqual(0.43, Math.Round(testTriangle.GetArea(), 2));

            testTriangle = new Triangle(3, 2, 4);
            Assert.AreEqual(2.9047, Math.Round(testTriangle.GetArea(), 4));

            testTriangle = new Triangle(10.45, 12.4, 4.5);
            Assert.AreEqual(22.713636, Math.Round(testTriangle.GetArea(), 6));
        }
    }

}