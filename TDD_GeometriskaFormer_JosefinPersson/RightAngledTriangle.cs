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


        //float[] IGeometricThing.totalPerimeter { get; set; }

        public float CalculateArea()
        {
            RightAngledTriangle rat = new RightAngledTriangle();
            rat.area = rat.baseSide * rat.sideA / 2;
            return rat.area;
        }

        public float CalculatePerimeter()
        {
            RightAngledTriangle rat = new RightAngledTriangle();
            rat.perimeter = rat.baseSide + rat.sideA + rat.hypotenuse;
            return rat.perimeter;
        }

        //public float CalculatePerimeterOfAll()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
