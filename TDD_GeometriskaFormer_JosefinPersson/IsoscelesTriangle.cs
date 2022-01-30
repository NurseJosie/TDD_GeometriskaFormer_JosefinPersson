namespace TDD_GeometriskaFormer_JosefinPersson     // ---------LIKBENT TRIANGEL------------
{
    public class IsoscelesTriangle : IGeometricThing, IGeometricCalculator
    {
        public float Area { get; set; }
        public float Perimeter { get; set; }
        public float SideA { get; set; }
        public float BaseSide { get; set; }
        public float Height { get; set; }

        /// <summary>
        /// Calculates the area.
        /// </summary>
        public float CalculateArea()
        {
            return BaseSide * Height / 2;
        }

        /// <summary>
        /// Calculates the perimeter.
        /// </summary>
        public float CalculatePerimeter()
        {
            return SideA * 2 + BaseSide;
        }
    }
}