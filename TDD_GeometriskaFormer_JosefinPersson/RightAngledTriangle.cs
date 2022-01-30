namespace TDD_GeometriskaFormer_JosefinPersson
{
    public class RightAngledTriangle : IGeometricCalculator, IGeometricThing
    {
        public float Area { get; set; }
        public float Perimeter { get; set; }
        public float SideA { get; set; }
        public float BaseSide { get; set; }
        public float Hypotenuse { get; set; }

        /// <summary>
        /// Calculates the area.
        /// </summary>
        public float CalculateArea()
        {
            return BaseSide * SideA / 2;
        }

        /// <summary>
        /// Calculates the perimeter.
        /// </summary>
        public float CalculatePerimeter()
        {
            return BaseSide + SideA + Hypotenuse;
        }
    }
}