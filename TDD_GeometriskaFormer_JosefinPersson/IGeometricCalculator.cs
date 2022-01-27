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
        float CalculateArea(); 
        //omkrets
        float CalculatePerimeter(); 
        //omkrets av allt
        float CalculatePerimeterOfAll(/*IGeometricThing.totalPerimeter[] totalPerimeters*/); 
    }
}
