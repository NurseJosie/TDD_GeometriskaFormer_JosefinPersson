namespace TDD_GeometriskaFormer_JosefinPersson
{
    public class Square : IGeometricThing, IGeometricCalculator
    {
        public float Area { get; set; }
        public float Perimeter { get; set; }
        public float Side { get; set; }

        /// <summary>
        /// Calculates the area.
        /// </summary>
        public float CalculateArea()
        {
            return Side * Side;
        }

        /// <summary>
        /// Calculates the perimeter.
        /// </summary>
        public float CalculatePerimeter()
        {
            return Side * 4;
        }
    }
}