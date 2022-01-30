namespace TDD_GeometriskaFormer_JosefinPersson
{
    public class Circle : IGeometricThing, IGeometricCalculator
    {
        public float Area { get; set; }
        public float Perimeter { get; set; }
        public float Radius { get; set; }

        /// <summary>
        /// Calculates the area.
        /// </summary>
        public float CalculateArea()
        {
            return (float)((Radius * Radius) * Math.PI);
        }

        /// <summary>
        /// Calculates the perimeter.
        /// </summary>
        public float CalculatePerimeter()
        {
            return (float)((Radius * 2) * Math.PI);
        }
    }
}