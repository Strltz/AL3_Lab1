using Lab1_1;
using System.Drawing;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Lab1_1.Point point1 = new Lab1_1.Point(1, 1);
        Lab1_1.Point point2 = new Lab1_1.Point(1, 4);
        Lab1_1.Point point3 = new Lab1_1.Point(5, 1);
        Lab1_1.Point point4 = new Lab1_1.Point(5, 4);

        [TestMethod]
        public void TestMethodRectangle()
        {
            Lab1_1.Rectangle rectangle1 = new Lab1_1.Rectangle(5, 6);

            Assert.AreEqual(rectangle1.Area, 30);
            Assert.AreEqual(rectangle1.Perimeter, 22);
        }

        [TestMethod]
        public void TestMethodPoint()
        {
            Assert.AreEqual(point1.coordX, 1);
            Assert.AreEqual(point1.coordY, 1);
            Assert.AreEqual(point2.coordX, 1);
            Assert.AreEqual(point2.coordY, 4);
            Assert.AreEqual(point3.coordX, 5);
            Assert.AreEqual(point1.coordY, 1);
        }

        [TestMethod]
        public void TestMethodFigure1()
        {
            Lab1_1.Figure figure1 = new Figure("fgr", point1, point2, point3);

            Assert.AreEqual(figure1.LengthSide(point2, point3), 5); // ((5-1)^2 + (4-1)^2) ^ (1/2) = 5
            Assert.AreEqual(figure1.PerimeterCalculator(), 12); // египетский треугольник
        }

        [TestMethod]
        public void TestMethodFigure2()
        {
            Lab1_1.Figure figure2 = new Figure("fgr", point1, point2, point4, point3);

            Assert.AreEqual(figure2.PerimeterCalculator(), 14); // египетский треугольник
        }
    }
}