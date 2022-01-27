using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_GeometriskaFormer_JosefinPersson
{
    internal class Rectangle : IGeometricThing, IGeometricCalculator
    {
        public float area { get; set; }
        public float perimeter { get; set; }
        public float width { get; set; } //width måste vara längre än height
        public float height { get; set; }   //height måste vara kortare än width
        public float[] totalPerimeter { get; set; }

        public float CalculateArea()
        {
           Rectangle rectangle = new Rectangle();
            rectangle.area = rectangle.width * rectangle.height;
            return rectangle.area;

        //    public class AreaCalculator   // kod från övningsuppgift
        //{
        //    public double Area(Rectangle[] shapes)
        //    {
        //        double area = 0;
        //        foreach (var shape in shapes)
        //        {
        //            area += shape.Width * shape.Height;
        //        }
        //        return area;
        //    }
        //}

        //public class Rectangle : Shape   // obs abstrakt klass......
        //{
        //    public double Width { get; set; }
        //    public double Height { get; set; }
        //    public override double Area()
        //    {
        //        return Width * Height;
        //    }
        //}
      
    }

        public float CalculatePerimeter()
        {
                Rectangle rectangle = new Rectangle();
                rectangle.perimeter = rectangle.width * 2 + rectangle.height * 2;
                return rectangle.perimeter;
            }

        public float CalculatePerimeterOfAll()
        {
            throw new NotImplementedException();
        }
    }
}
