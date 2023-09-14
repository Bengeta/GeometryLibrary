namespace Figures;
public class Triangle : Shape
{
    private double SideA { get; }
    private double SideB { get; }
    private double SideC { get; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            throw new ArgumentException("Длины сторон треугольника должны быть положительными.");
        if (!IsTriangleValid(sideA, sideB, sideC))
            throw new ArgumentException("Треугольник с такими сторонами не существует.");

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public override double CalculateArea()
    {
        var s = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }

    // Метод для проверки, является ли треугольник прямоугольным
    public bool IsRightTriangle()
    {
        double[]  sides = { SideA, SideB, SideC };
        Array.Sort(sides);

        return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
    }

    private static bool IsTriangleValid(double sideA, double sideB, double sideC)
    {
        return sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA;
    }
}