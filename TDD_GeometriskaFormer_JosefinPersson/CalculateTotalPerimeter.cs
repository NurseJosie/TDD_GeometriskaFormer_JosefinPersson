namespace TDD_GeometriskaFormer_JosefinPersson
{
    /// <summary>
    /// Calculates the total perimeter.
    /// </summary>
    public class CalculateTotalPerimeter
    {
        public float TotalPerimeter(IGeometricThing[] totalPerimeter)
        {
            float totalPerimeterValue = 0;

            for (int i = 0; i < totalPerimeter.Length; i++)
            {
                totalPerimeterValue += totalPerimeter[i].Perimeter;
            }

            return totalPerimeterValue;
        }
    }
}