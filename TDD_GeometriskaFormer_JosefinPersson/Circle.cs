using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_GeometriskaFormer_JosefinPersson
{
    public class Circle : IGeometricThing, IGeometricCalculator
    {
        public float area { get; set; }
        public float perimeter { get; set; }
        public float radius { get; set; }

        public float CalculateArea()
        {
           // radie upphöjt till 2 * PI
            return (float)((radius * radius) * Math.PI);
        }

        //public float CalculateArea(Square square)
        //{
        //    return square.CalculateArea();
        //}

        public float CalculatePerimeter()
        {
            return (float)((radius * 2) * Math.PI);    //diametern * PI
        }

        //public float CalculatePerimeter(Square square)
        //{
        //    return square.CalculatePerimeter();
        //}
    }
}
