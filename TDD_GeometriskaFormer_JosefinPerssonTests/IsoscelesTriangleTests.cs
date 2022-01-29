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
    public class IsoscelesTriangleTests
    {
        [TestMethod()]
        public void CalculateAreaTest_Fail()
        {
            //arrange
            IsoscelesTriangle sut = new IsoscelesTriangle();
            sut.baseSide = 10;
            sut.height = 13.7373870973f;
            //act
            var result = sut.CalculateArea();
            //assert
            Assert.AreNotEqual(1, result);
        }

        [TestMethod()]
        public void CalculateAreaTest_Pass()
        {
            //arrange
            IsoscelesTriangle sut = new IsoscelesTriangle();
            sut.baseSide = 10;
            sut.height = 13.7373870973f;
            //act
            var result = sut.CalculateArea();
            //assert
            Assert.AreEqual(68.6869354f, result);
        }

        [TestMethod()]
        public void CalculatePerimeterTest_Fail()
        {
            //arrange
            IsoscelesTriangle sut = new IsoscelesTriangle();
            sut.sideA = 10;
            sut.baseSide = 6.8404028665f;
            //act
            var result = sut.CalculatePerimeter();
            //assert
            Assert.AreNotEqual(1, result);
        }

        [TestMethod()]
        public void CalculatePerimeterTest_Pass()
        {
            //arrange
            IsoscelesTriangle sut = new IsoscelesTriangle();
            sut.sideA = 10;
            sut.baseSide = 6.8404028665f;
            //act
            var result = sut.CalculatePerimeter();
            //assert
            Assert.AreEqual(26.840403f, result);
        }
    }
}