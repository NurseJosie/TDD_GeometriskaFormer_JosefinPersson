namespace TDD_GeometriskaFormer_JosefinPersson //-----------LIKSIDIG TRIANGEL--------------
{
    public class EquilateralTriangle : IGeometricCalculator, IGeometricThing
    {
        public float Area { get; set; }
        public float Perimeter { get; set; }
        public float SideA { get; set; }
        public float Height { get; set; }

        /// <summary>
        /// Calculates the area.
        /// </summary>
        public float CalculateArea()
        {
            return SideA * Height / 2;
        }

        /// <summary>
        /// Calculates the perimeter.
        /// </summary>
        public float CalculatePerimeter()
        {
            return SideA * 3;
        }
    }
}