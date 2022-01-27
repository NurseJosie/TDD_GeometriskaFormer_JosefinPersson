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


       // float[] IGeometricThing.totalPerimeter { get; set; }

        public float CalculateArea()
        {
            EquilateralTriangle et = new EquilateralTriangle();
            et.area = et.sideA * height / 2;            // korrekt uträkning???
            return et.area;
        }

        public float CalculatePerimeter()
        {
            EquilateralTriangle et = new EquilateralTriangle();
            et.perimeter = sideA * 3;
            return et.perimeter;
        }

        //public float CalculatePerimeterOfAll()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
