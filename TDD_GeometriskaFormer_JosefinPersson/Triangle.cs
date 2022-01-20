using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_GeometriskaFormer_JosefinPersson
{
    internal class Triangle : IGeometricThing, IGeometricCalculator  // räkvinklig, likbent, liksidig... arv/interface/polymorphism eller tre olika klasser???
    {
        // bas base
        // höjd height
        // hypotenusa hypotenuse

        //rät
        // bas2+höjd2=hypotenusa2     pythagoras...

        //likbent
        // höjd och hypotenusa måste ha samma längd
        //basen måste vara korare än höjd och hypotenusa

        //liksidig
        // alla sidor måste vara lika långa


        //public float base {get; set;}
        public float area { get; set; }
        public float perimeter { get; set; }
        float[] IGeometricThing.totalPerimeter { get; set; }

        public float CalculateArea()
        {
            throw new NotImplementedException();
        }

        public float CalculatePerimeter()
        {
            throw new NotImplementedException();
        }

        public float CalculatePerimeterOfAll()
        {
            throw new NotImplementedException();
        }
    }
}
