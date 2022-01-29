using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_GeometriskaFormer_JosefinPersson     // -------LIKBENT TRIANGEL-----benen är lika långa, basen...--------
{
    public class IsoscelesTriangle: Triangle, IGeometricThing, IGeometricCalculator
    {
        public float area { get; set; }
        public float perimeter { get; set; }
        public float sideA { get; set; }  // 2 lika långa sidor
        public float baseSide { get; set; }
        public float height { get; set; }

        public float CalculateArea()
        {     
            return baseSide * height / 2;
        }

        //public float CalculateArea(Square square)
        //{
        //    return square.CalculateArea();
        //}

        public float CalculatePerimeter()
        {
            return sideA * 2 + baseSide;
        }

        //public float CalculatePerimeter(Square square)
        //{
        //    return square.CalculatePerimeter();
        //}
    }
}
