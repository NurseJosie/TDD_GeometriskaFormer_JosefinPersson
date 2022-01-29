using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_GeometriskaFormer_JosefinPersson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_GeometriskaFormer_JosefinPersson.Tests
{
    [TestClass()]
    public class RightAngledTriangleTests
    {
        [TestMethod()]
        public void CalculateAreaTest_Fail()
        {
            //arrange
            RightAngledTriangle sut = new RightAngledTriangle();
            sut.baseSide = 2;
            sut.sideA = 2;
            //act
            var result = sut.CalculateArea();
            //assert
            Assert.AreNotEqual(1, result);
        }

        [TestMethod()]
        public void CalculateAreaTest_Pass()
        {
            //arrange
            RightAngledTriangle sut = new RightAngledTriangle();
            sut.baseSide = 2;
            sut.sideA = 2;
            //act
            var result = sut.CalculateArea();
            //assert
            Assert.AreEqual(2, result);
        }

        [TestMethod()]
        public void CalculatePerimeterTest_Fail()
        {
            //arrange
            RightAngledTriangle sut = new RightAngledTriangle();
            sut.baseSide = 2;
            sut.sideA = 2;
            sut.hypotenuse = 8;
            //act
            var result = sut.CalculatePerimeter();
            //assert
            Assert.AreNotEqual(1, result);
        }

        [TestMethod()]
        public void CalculatePerimeterTest_Pass()
        {
            //arrange
            RightAngledTriangle sut = new RightAngledTriangle();
            sut.baseSide = 2;
            sut.sideA = 2;
            sut.hypotenuse = 8;
            //act
            var result = sut.CalculatePerimeter();
            //assert
            Assert.AreEqual(12, result);
        }
    }
}