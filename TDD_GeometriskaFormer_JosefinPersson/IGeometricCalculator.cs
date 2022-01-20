using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_GeometriskaFormer_JosefinPersson
{
    public interface IGeometricCalculator // metoder för att räkna ut omkrets och area som alla har gemensamt
    {
        //area
        float CalculateArea(); //return ngt?
        //omkrets
        float CalculatePerimeter(); //return ngt?
        //omkrets av allt
        float CalculatePerimeterOfAll(/*IGeometricThing.totalPerimeter[] totalPerimeters*/); //return ngt?


        //public void GetArea(IGeometricThing thing) // räknar arean
        //{
        //    //cirkel: pi x radie(upphöjt till)2

        //    //kvadrat: bas x höjd

        //    //rektangel: bas x höjd

        //    //triangel: bas x höjd / 2
        //    //rät.
        //    //likb.
        //    //liks.
        //}

        //public void GetPerimeter(IGeometricThing thing) // räknar omkretsen
        //{
        //    //cirkel: diameter x pi

        //    //kvadrat: a x 4

        //    //rektangel: 

        //    //triangel: a + b + c
        //    //rät.
        //    //likb.
        //    //liks.
        //}

        //public void GetPerimeter(IGeometricThing[] thing) // räknar ut sammanlagd omkrets av flera figurer, se PP...???
        //{
        //    // ...???
        //}
    }
}
