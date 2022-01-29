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
    public class EquilateralTriangleTests
    {
        [TestMethod()]
        public void CalculateAreaTest_Fail()
        {
            //arrange
            EquilateralTriangle sut = new EquilateralTriangle();
            sut.sideA = 10;
            sut.height = 8.6602540378f;
            //act
            var result = sut.CalculateArea();
            //assert
            Assert.AreNotEqual(1, result);
        }

        [TestMethod()]
        public void CalculateAreaTest_Pass()
        {
            //arrange
            EquilateralTriangle sut = new EquilateralTriangle();
            sut.sideA = 10;
            sut.height = 8.6602540378f;
            //act
            var result = sut.CalculateArea();
            //assert
            Assert.AreEqual(43.3012733f, result);
        }


        [TestMethod()]
        public void CalculatePerimeterTest_Fail()
        {
            //arrange
            EquilateralTriangle sut = new EquilateralTriangle();
            sut.sideA = 10;
            //act
            var result = sut.CalculatePerimeter();
            //assert
            Assert.AreNotEqual(1, result);
        }

        [TestMethod()]
        public void CalculatePerimeterTest_Pass()
        {
            //arrange
            EquilateralTriangle sut = new EquilateralTriangle();
            sut.sideA = 10;
            //act
            var result = sut.CalculatePerimeter();
            //assert
            Assert.AreEqual(30, result);
        }
    }
}