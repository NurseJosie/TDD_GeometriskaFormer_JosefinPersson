using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_GeometriskaFormer_JosefinPersson
{
    public class Square : IGeometricThing, IGeometricCalculator
    {
        public float area { get; set; }
        public float perimeter { get; set; }
        public float side { get; set; }
       // public float[] totalPerimeter { get; set; }

        public float CalculateArea()
        {
            Square square = new Square();
            square.area = square.side * square.side;
            return square.area;
        }

        public float CalculatePerimeter()
        {
            Square square = new Square();
            square.perimeter = square.side * 4;
            return square.perimeter;
        }

        //public float CalculatePerimeterOfAll()
        //{
        //    // från lätta solid-övningar, lägg ihop allt i en area-variabel. vart ska denna ligga? i alla shapes? adderas till vart?

        //    //    public class AreaCalculator       
        //    //{
        //    //    public double Area(Rectangle[] shapes)
        //    //    {
        //    //        double area = 0;
        //    //        foreach (var shape in shapes)
        //    //        {
        //    //            area += shape.Width * shape.Height;
        //    //        }
        //    //        return area;
        //    //    }
        //    //}
        //    //    public class AreaCalculator
        //    //{
        //    //    public double Area(Shape[] shapes)
        //    //    {
        //    //        double area = 0;
        //    //        foreach (var shape in shapes)
        //    //        {
        //    //            area += shape.Area();
        //    //        }
        //    //        return area;
        //    //    }
        //    //}
        //    //Square square = new Square();
        //    //square.perimeter = square.side * 4;

        //    //(totalPerimeter[] Square)
        //    //{
        //    //    foreach (var square in Square)
        //    //    {
        //    //        totalPerimeter[] += square.perimeter();
        //    //    }
        //    //}
        //    return totalPerimeter[];
        //}
    }
}
