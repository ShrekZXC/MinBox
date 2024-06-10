using ShapeLibrary;
using Xunit;
using Assert = Xunit.Assert;

namespace ShapeTests;

public class CircleTests
{
    [Fact]
    public void GetArea_ValidRadius_ReturnsCorrectArea()
    {
        var circle = new Circle(5);
        double area = circle.GetArea();
        Assert.Equal(Math.PI * 25, area, precision:5);
    }

    [Fact]
    public void Constructor_NegativeRadius_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-5));
    }
}