using Xunit;
using Mindbox;

public class ShapeTests
{
    [Fact]
    public void TestCircleArea()
    {
        var circle = new Circle(5);
        var area = circle.CalculateArea();
        Assert.Equal(78.54, area, 2); // Проверяем с точностью до 2 знаков
    }

    [Fact]
    public void TestTriangleArea()
    {
        var triangle = new Triangle(3, 4, 5);
        var area = triangle.CalculateArea();
        Assert.Equal(6, area);
    }

    [Fact]
    public void TestRightTriangle()
    {
        var triangle = new Triangle(3, 4, 5);
        var isRight = triangle.IsRightAngled();
        Assert.True(isRight);
    }

    [Fact]
    public void TestInvalidTriangle()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 3));
    }
}
