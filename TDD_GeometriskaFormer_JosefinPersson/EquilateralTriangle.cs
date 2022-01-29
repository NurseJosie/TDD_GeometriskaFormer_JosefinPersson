using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_GeometriskaFormer_JosefinPersson //-----------LIKSIDIG TRIANGEL--- ALLA SIDOR LIKA LÅNGA-------
{
    public class EquilateralTriangle : Triangle, IGeometricCalculator, IGeometricThing
    {
        public float area { get; set; }
        public float perimeter { get; set; }
        public float sideA { get; set; }  // alla sidor lika långa
        public float height { get; set; }

        public float CalculateArea()
        {   
            return sideA * height / 2;
        }

        //public float CalculateArea(Square square)
        //{
        //    return square.CalculateArea();
        //}

        public float CalculatePerimeter()
        {
            return sideA * 3;
        }

        //public float CalculatePerimeter(Square square)
        //{
        //    return square.CalculatePerimeter();
        //}
    }
}
