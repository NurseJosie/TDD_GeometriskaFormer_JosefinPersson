using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_GeometriskaFormer_JosefinPersson
{
    public class Square : IGeometricThing, IGeometricCalculator
    {
        public float area { get; set; }
        public float perimeter { get; set; }
        public float side { get; set; }

        public float CalculateArea()
        {
            return side * side;
        }

        //public float CalculateArea(Square square)
        //{
        //    return square.CalculateArea();
        //}
        public float CalculatePerimeter()
        {
            return side * 4;
        }

        //public float CalculatePerimeter(Square square)
        //{
        //    return square.CalculatePerimeter();
        //}
    }
}
