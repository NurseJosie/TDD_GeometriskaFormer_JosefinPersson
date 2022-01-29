using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_GeometriskaFormer_JosefinPersson
{
    public class RightAngledTriangle : Triangle, IGeometricCalculator, IGeometricThing 
    {
        public float area { get; set; }
        public float perimeter { get; set; }
        public float sideA { get; set; }
        public float baseSide { get; set; }   // phytagoras....
        public float hypotenuse { get; set; }

        public float CalculateArea()
        {
            return baseSide * sideA / 2;
        }

        //public float CalculateArea(Square square)
        //{
        //    return square.CalculateArea();
        //}

        public float CalculatePerimeter()
        {
            return baseSide + sideA + hypotenuse;
        }

        //public float CalculatePerimeter(Square square)
        //{
        //    return square.CalculatePerimeter();
        //}
    }
}
