using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD_GeometriskaFormer_JosefinPersson.Tests
{
    [TestClass()]
    public class EquilateralTriangleTests
    {
        /// <summary>
        /// Calculates the area test fail.
        /// </summary>
        [TestMethod()]
        public void CalculateAreaTest_Fail()
        {
            //arrange
            EquilateralTriangle sut = new EquilateralTriangle();
            sut.SideA = 10;
            sut.Height = 8.6602540378f;
            //act
            var result = sut.CalculateArea();
            //assert
            Assert.AreNotEqual(1, result);
        }

        /// <summary>
        /// Calculates the area test pass.
        /// </summary>
        [TestMethod()]
        public void CalculateAreaTest_Pass()
        {
            //arrange
            EquilateralTriangle sut = new EquilateralTriangle();
            sut.SideA = 10;
            sut.Height = 8.6602540378f;
            //act
            var result = sut.CalculateArea();
            //assert
            Assert.AreEqual(43.3012733f, result);
        }

        /// <summary>
        /// Calculates the perimeter test fail.
        /// </summary>
        [TestMethod()]
        public void CalculatePerimeterTest_Fail()
        {
            //arrange
            EquilateralTriangle sut = new EquilateralTriangle();
            sut.SideA = 10;
            //act
            var result = sut.CalculatePerimeter();
            //assert
            Assert.AreNotEqual(1, result);
        }

        /// <summary>
        /// Calculates the perimeter test pass.
        /// </summary>
        [TestMethod()]
        public void CalculatePerimeterTest_Pass()
        {
            //arrange
            EquilateralTriangle sut = new EquilateralTriangle();
            sut.SideA = 10;
            //act
            var result = sut.CalculatePerimeter();
            //assert
            Assert.AreEqual(30, result);
        }
    }
}