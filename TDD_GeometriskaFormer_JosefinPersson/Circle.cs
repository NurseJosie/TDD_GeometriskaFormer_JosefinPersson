using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_GeometriskaFormer_JosefinPersson
{
    public class Circle : IGeometricThing, IGeometricCalculator
    {
        // radius
        public float area { get; set; }
        public float perimeter { get; set; }
        public float radius { get; set; }
       // public float[] totalPerimeter { get; set; }

        public float CalculateArea()
        {
            Circle circle = new Circle();
            circle.area = (float)((circle.radius * circle.radius) * Math.PI);          // radie upphöjt till 2 * PI
            return circle.area;
        }

        public float CalculatePerimeter()
        {
            Circle circle = new Circle();
            circle.perimeter = (float)((circle.radius * 2) * Math.PI);    //diametern * PI
            return circle.perimeter;
        }

        //public float CalculatePerimeterOfAll()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
