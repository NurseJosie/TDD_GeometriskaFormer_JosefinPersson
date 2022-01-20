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
        public void CalculateArea_WidthHeightAreSame_ReturnsTrue()
        {
            //arrange
            Square sut = new Square();
            sut.width = 1;
            sut.height = 1;
           
            //act
            var area = sut.CalculateArea(/*???*/);

            //assert
            Assert.IsTrue(area != null); // ???

        }
    }
}