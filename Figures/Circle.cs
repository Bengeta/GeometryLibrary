namespace Figures;
public class Circle : Shape
{
    private double Radius { get; }

    public Circle(double radius)
    {
        if (radius < 0)
            throw new ArgumentException("Радиус не может быть отрицательным.");
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}