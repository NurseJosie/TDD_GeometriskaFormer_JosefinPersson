using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_GeometriskaFormer_JosefinPersson
{
    public class Square : IGeometricThing, IGeometricCalculator
    {
        // side a alt width, height
        // width och height måste vara lika långa
        public float area { get; set; }
        public float perimeter { get; set; }
        public float width { get; set; }
        public float height { get; set; }
        public float[] totalPerimeter { get; set; }

        public float CalculateArea()
        {
            Square square = new Square();
            //square.width = 5f; //? behöver jag ange siffra här? räcker att ange i testet?
            //square.height = 5f;
            square.area = square.width * square.height;
            return square.area;

            //public class Rectangle : Shape
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
            Square square = new Square();
            //square.width = 5f;
            //square.height = 5f;
            square.perimeter = square.width * 4;
            return square.perimeter;
        }

        public float CalculatePerimeterOfAll()
        {
            // ???
            //    public class AreaCalculator    // från lätta solid-övningar, lägg ihop allt i en area-variabel. vart ska denna ligga? i alla shapes? adderas till vart?
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
        //    public class AreaCalculator
        //{
        //    public double Area(Shape[] shapes)
        //    {
        //        double area = 0;
        //        foreach (var shape in shapes)
        //        {
        //            area += shape.Area();
        //        }
        //        return area;
        //    }
        //}
  

            return CalculatePerimeter(); // ???
        }
    }
}
