using Interfaces;

namespace Figures;
public class Circle : IFigure
{
    private double Radius { get; }

    public Circle(double radius)
    {
        if (radius < 0)
            throw new ArgumentException("Радиус не может быть отрицательным.");
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}