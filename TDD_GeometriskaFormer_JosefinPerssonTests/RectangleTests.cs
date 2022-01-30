using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD_GeometriskaFormer_JosefinPersson.Tests
{
    [TestClass()]
    public class RectangleTests
    {
        /// <summary>
        /// Calculates the area test fail.
        /// </summary>
        [TestMethod()]
        public void CalculateAreaTest_Fail()
        {
            //arrange
            Rectangle sut = new Rectangle();
            sut.Width = 4;
            sut.Height = 2;
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
            Rectangle sut = new Rectangle();
            sut.Width = 4;
            sut.Height = 2;
            //act
            var result = sut.CalculateArea();
            //assert
            Assert.AreEqual(8, result);
        }

        /// <summary>
        /// Calculates the perimeter test fail.
        /// </summary>
        [TestMethod()]
        public void CalculatePerimeterTest_Fail()
        {
            //arrange
            Rectangle sut = new Rectangle();
            sut.Width = 4;
            sut.Height = 2;
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
            Rectangle sut = new Rectangle();
            sut.Width = 4;
            sut.Height = 2;
            //act
            var result = sut.CalculatePerimeter();
            //assert
            Assert.AreEqual(12, result);
        }
    }
}