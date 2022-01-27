using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_GeometriskaFormer_JosefinPersson
{
    public interface IGeometricThing  // properies
    {
        //area
        float area { get; set; }   // skriv aldrig modifiers i ett interface, allt måste vara public så det sker automatiskt
        //omkrets
        float perimeter { get; set; }

        //float[] totalPerimeter { get; set; } // behövs som property?
    }
}
