namespace TDD_GeometriskaFormer_JosefinPersson
{
    public class Rectangle : IGeometricThing, IGeometricCalculator
    {
        public float Area { get; set; }
        public float Perimeter { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }

        /// <summary>
        /// Calculates the area.
        /// </summary>
        public float CalculateArea()
        {
            return Width * Height;
        }

        /// <summary>
        /// Calculates the perimeter.
        /// </summary>
        public float CalculatePerimeter()
        {
            return Width * 2 + Height * 2;
        }
    }
}