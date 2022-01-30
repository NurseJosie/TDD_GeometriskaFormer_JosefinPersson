using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD_GeometriskaFormer_JosefinPersson.Tests
{
    [TestClass()]
    public class IsoscelesTriangleTests
    {
        /// <summary>
        /// Calculates the area test fail.
        /// </summary>
        [TestMethod()]
        public void CalculateAreaTest_Fail()
        {
            //arrange
            IsoscelesTriangle sut = new IsoscelesTriangle();
            sut.BaseSide = 10;
            sut.Height = 13.7373870973f;
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
            IsoscelesTriangle sut = new IsoscelesTriangle();
            sut.BaseSide = 10;
            sut.Height = 13.7373870973f;
            //act
            var result = sut.CalculateArea();
            //assert
            Assert.AreEqual(68.6869354f, result);
        }

        /// <summary>
        /// Calculates the perimeter test fail.
        /// </summary>
        [TestMethod()]
        public void CalculatePerimeterTest_Fail()
        {
            //arrange
            IsoscelesTriangle sut = new IsoscelesTriangle();
            sut.SideA = 10;
            sut.BaseSide = 6.8404028665f;
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
            IsoscelesTriangle sut = new IsoscelesTriangle();
            sut.SideA = 10;
            sut.BaseSide = 6.8404028665f;
            //act
            var result = sut.CalculatePerimeter();
            //assert
            Assert.AreEqual(26.840403f, result);
        }
    }
}