using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_GeometriskaFormer_JosefinPersson
{
    public class Rectangle : IGeometricThing, IGeometricCalculator
    {
        public float area { get; set; }
        public float perimeter { get; set; }
        public float width { get; set; } //width måste vara längre än height
        public float height { get; set; }   //height måste vara kortare än width

        public float CalculateArea()
        {
            return width * height;
        }
        //public float CalculateArea(Square square)
        //{
        //    return square.CalculateArea();
        //}

        public float CalculatePerimeter()
        {
            return width * 2 + height * 2;
        }
        //public float CalculatePerimeter(Square square)
        //{
        //    return square.CalculatePerimeter();
        //}
    }
}
