using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD_GeometriskaFormer_JosefinPersson.Tests
{
    [TestClass()]
    public class RightAngledTriangleTests
    {
        /// <summary>
        /// Calculates the area test fail.
        /// </summary>
        [TestMethod()]
        public void CalculateAreaTest_Fail()
        {
            //arrange
            RightAngledTriangle sut = new RightAngledTriangle();
            sut.BaseSide = 2;
            sut.SideA = 2;
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
            RightAngledTriangle sut = new RightAngledTriangle();
            sut.BaseSide = 2;
            sut.SideA = 2;
            //act
            var result = sut.CalculateArea();
            //assert
            Assert.AreEqual(2, result);
        }

        /// <summary>
        /// Calculates the perimeter test fail.
        /// </summary>
        [TestMethod()]
        public void CalculatePerimeterTest_Fail()
        {
            //arrange
            RightAngledTriangle sut = new RightAngledTriangle();
            sut.BaseSide = 2;
            sut.SideA = 2;
            sut.Hypotenuse = 8;
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
            RightAngledTriangle sut = new RightAngledTriangle();
            sut.BaseSide = 2;
            sut.SideA = 2;
            sut.Hypotenuse = 8;
            //act
            var result = sut.CalculatePerimeter();
            //assert
            Assert.AreEqual(12, result);
        }
    }
}