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
    public class RectangleTests
    {
        [TestMethod()]
        public void CalculateAreaTest_Fail()
        {
            //arrange
            Rectangle sut = new Rectangle();
            sut.width = 4;
            sut.height = 2;
            //act
            var result = sut.CalculateArea();
            //assert
            Assert.AreNotEqual(1, result);
        }

        [TestMethod()]
        public void CalculateAreaTest_Pass()
        {
            //arrange
            Rectangle sut = new Rectangle();
            sut.width = 4;
            sut.height = 2;
            //act
            var result = sut.CalculateArea();
            //assert
            Assert.AreEqual(8, result);
        }

        [TestMethod()]
        public void CalculatePerimeterTest_Fail()
        {
            //arrange
            Rectangle sut = new Rectangle();
            sut.width = 4;
            sut.height = 2;
            //act
            var result = sut.CalculatePerimeter();
            //assert
            Assert.AreNotEqual(1, result);
        }

        [TestMethod()]
        public void CalculatePerimeterTest_Pass()
        {
            //arrange
            Rectangle sut = new Rectangle();
            sut.width = 4;
            sut.height = 2;
            //act
            var result = sut.CalculatePerimeter();
            //assert
            Assert.AreEqual(12, result);
        }
    }
}