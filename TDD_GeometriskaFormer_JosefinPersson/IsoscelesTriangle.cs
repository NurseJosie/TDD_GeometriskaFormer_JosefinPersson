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

       // float[] IGeometricThing.totalPerimeter { get; set; }

        public float CalculateArea()
        {
            IsoscelesTriangle it = new IsoscelesTriangle();
            it.area = it.baseSide * it.height / 2;           // korrekt uträkning???
            return it.area;
        }

        public float CalculatePerimeter()
        {
            IsoscelesTriangle it = new IsoscelesTriangle();
            it.perimeter = it.sideA * 2 + baseSide;
            return it.perimeter;
        }

        //public float CalculatePerimeterOfAll()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
