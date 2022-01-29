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
    public class CircleTests
    {
        [TestMethod()]
        public void CalculateAreaTest_Fail()
        {
            //arrange
            Circle sut = new Circle();
            sut.radius = 2;
            //act
            var result = sut.CalculateArea();
            //assert
            Assert.AreNotEqual(1, result);
        }

        [TestMethod()]
        public void CalculateAreaTest_Pass()
        {
            //arrange
            Circle sut = new Circle();
            sut.radius = 2;
            //act
            var result = sut.CalculateArea();
            //assert
            Assert.AreEqual(12.566371f, result);
        }

        [TestMethod()]
        public void CalculatePerimeterTest_Fail()
        {
            //arrange
            Circle sut = new Circle();
            sut.radius = 2;
            //act
            var result = sut.CalculatePerimeter();
            //assert
            Assert.AreNotEqual(1, result);
        }

        [TestMethod()]
        public void CalculatePerimeterTest_Pass()
        {
            //arrange
            Circle sut = new Circle();
            sut.radius = 3;
            //act
            var result = sut.CalculatePerimeter();
            //assert
            Assert.AreEqual(18.849556f, result);
        }
    }
}