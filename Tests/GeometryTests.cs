using Figures;
using NUnit.Framework;

namespace GeometryLibrary.Tests;
[TestFixture]
public class GeometryTests
{
    [Test]
    public void CircleAreaCalculation()
    {
        var circle = new Circle(5);

        var area = circle.CalculateArea();

        Assert.AreEqual(78.53981633974483, area, 1e-9);
    }

    [Test]
    public void TriangleAreaCalculation()
    {
        var triangle = new Triangle(3, 4, 5);

        var area = triangle.CalculateArea();

        Assert.AreEqual(6, area);
    }

    [Test]
    public void RightTriangleCheck()
    {
        var triangle = new Triangle(3, 4, 5);

        var isRightTriangle = triangle.IsRightTriangle();

        Assert.IsTrue(isRightTriangle);
    }

    [Test]
    public void NonRightTriangleCheck()
    {
        var triangle = new Triangle(2, 3, 4);
 
        var isRightTriangle = triangle.IsRightTriangle();

        Assert.IsFalse(isRightTriangle);
    }
}

