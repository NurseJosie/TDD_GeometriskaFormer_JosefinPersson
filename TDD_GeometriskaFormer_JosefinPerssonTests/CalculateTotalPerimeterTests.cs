using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD_GeometriskaFormer_JosefinPersson.Tests
{
    [TestClass()]
    public class CalculateTotalPerimeterTests
    {
        /// <summary>
        /// Totals the perimeter test fail.
        /// </summary>
        [TestMethod()]
        public void TotalPerimeterTest_Fail()
        {
            //Arrange
            Square square = new();
            square.Perimeter = 1;

            Rectangle rectangle = new();
            rectangle.Perimeter = 2;

            Circle circle = new();
            circle.Perimeter = 3;

            RightAngledTriangle rat = new();
            rat.Perimeter = 4;

            IsoscelesTriangle it = new();
            it.Perimeter = 5;

            EquilateralTriangle et = new();
            et.Perimeter = 6;

            IGeometricThing[] totalPerimeter = { square, rectangle, circle, rat, it, et };
            CalculateTotalPerimeter calc = new CalculateTotalPerimeter();

            //Act
            var result = calc.TotalPerimeter(totalPerimeter);

            //Assert
            Assert.AreNotEqual(1, result);
        }

        /// <summary>
        /// Totals the perimeter test pass.
        /// </summary>
        [TestMethod()]
        public void TotalPerimeterTest_Pass()
        {
            //Arrange
            Square square = new();
            square.Perimeter = 1;

            Rectangle rectangle = new();
            rectangle.Perimeter = 2;

            Circle circle = new();
            circle.Perimeter = 3;

            RightAngledTriangle rat = new();
            rat.Perimeter = 4;

            IsoscelesTriangle it = new();
            it.Perimeter = 5;

            EquilateralTriangle et = new();
            et.Perimeter = 6;

            IGeometricThing[] totalPerimeter = { square, rectangle, circle, rat, it, et };
            CalculateTotalPerimeter calc = new CalculateTotalPerimeter();

            //Act
            var result = calc.TotalPerimeter(totalPerimeter);

            //Assert
            Assert.AreEqual(21, result);
        }
    }
}