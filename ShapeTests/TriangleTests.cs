using ShapeLibrary;
using Xunit;
using Assert = Xunit.Assert;

namespace ShapeTests;

public class TriangleTests
{
    [Fact]
    public void GetArea_ValidSides_ReturnsCorrectArea()
    {
        var triangle = new Triangle(3, 4, 5);
        double area = triangle.GetArea();
        Assert.Equal(6, area, precision:5);
    }

    [Fact]
    public void IsRightTriangle_ValidRightTriangle_ReturnsTrue()
    {
        var triangle = new Triangle(3, 4, 5);
        bool isRight = triangle.IsRightTriangle();
        Assert.True(isRight);
    }

    [Fact]
    public void Constructor_InvalidTriangle_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 10));
    }
}