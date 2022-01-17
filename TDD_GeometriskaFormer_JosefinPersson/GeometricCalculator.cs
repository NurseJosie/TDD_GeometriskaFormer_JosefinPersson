using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_GeometriskaFormer_JosefinPersson
{
    internal class GeometricCalculator  // klassen som ska göra alla beräkningar
    {
        public void GetArea(IGeometricThing thing) // räknar arean
        {
            //cirkel: pi x radie(upphöjt till)2

            //kvadrat: bas x höjd

            //rektangel: bas x höjd

            //triangel: bas x höjd / 2
            //rät.
            //likb.
            //liks.
        }

        public void GetPerimeter(IGeometricThing thing) // räknar omkretsen
        {
            //cirkel: diameter x pi

            //kvadrat: a x 4

            //rektangel:

            //triangel: a + b + c
            //rät.
            //likb.
            //liks.
        }

        public void GetPerimeter(IGeometricThing[] thing) // räknar ut sammanlagd omkrets av flera figurer, se PP...???
        {
            // ...???
        }
    }
}
