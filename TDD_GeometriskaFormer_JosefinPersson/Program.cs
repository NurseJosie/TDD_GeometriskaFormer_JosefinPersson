using TDD_GeometriskaFormer_JosefinPersson;

Square square = new();
Rectangle rectangle = new();
Circle circle = new();
RightAngledTriangle rat = new();
IsoscelesTriangle it = new();
EquilateralTriangle et = new();

float[] totalPerimeter = { square.perimeter, rectangle.perimeter, circle.perimeter, rat.perimeter, it.perimeter, et.perimeter };
float totalPerimeterValue = 0;

for (int i = 0; i < totalPerimeter.Length; i++)
{
    totalPerimeterValue += totalPerimeter[i];
}

// hur testas denna????