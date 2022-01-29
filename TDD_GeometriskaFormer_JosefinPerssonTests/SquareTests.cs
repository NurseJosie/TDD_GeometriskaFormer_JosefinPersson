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
    public class SquareTests
    {
        [TestMethod()]
        public void CalculateAreaTest_Fail()
        {
            //arrange
            Square sut = new Square();
            sut.side = 2;
            //act
            var result = sut.CalculateArea();
            //assert
            Assert.AreNotEqual(1, result);
        }

        [TestMethod()]
        public void CalculateAreaTest_Pass()
        {
            //arrange
            Square sut = new Square();
            sut.side = 2;
            //act
            var result = sut.CalculateArea();
            //assert
            Assert.AreEqual(4, result);
        }

        [TestMethod()]
        public void CalculatePerimeterTest_Fail()
        {
            //arrange
            Square sut = new Square();
            sut.side = 2;
            //act
            var result = sut.CalculatePerimeter();
            //assert
            Assert.AreNotEqual(1, result);
        }

        [TestMethod()]
        public void CalculatePerimeterTest_Pass()
        {
            //arrange
            Square sut = new Square();
            sut.side = 2;
            //act
            var result = sut.CalculatePerimeter();
            //assert
            Assert.AreEqual(8, result);
        }
    }
}