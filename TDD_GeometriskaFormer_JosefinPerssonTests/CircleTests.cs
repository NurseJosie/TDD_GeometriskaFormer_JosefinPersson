using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD_GeometriskaFormer_JosefinPersson.Tests
{
    [TestClass()]
    public class CircleTests
    {
        /// <summary>
        /// Calculates the area test fail.
        /// </summary>
        [TestMethod()]
        public void CalculateAreaTest_Fail()
        {
            //arrange
            Circle sut = new Circle();
            sut.Radius = 2;
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
            Circle sut = new Circle();
            sut.Radius = 2;
            //act
            var result = sut.CalculateArea();
            //assert
            Assert.AreEqual(12.566371f, result);
        }

        /// <summary>
        /// Calculates the perimeter test fail.
        /// </summary>
        [TestMethod()]
        public void CalculatePerimeterTest_Fail()
        {
            //arrange
            Circle sut = new Circle();
            sut.Radius = 2;
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
            Circle sut = new Circle();
            sut.Radius = 3;
            //act
            var result = sut.CalculatePerimeter();
            //assert
            Assert.AreEqual(18.849556f, result);
        }
    }
}