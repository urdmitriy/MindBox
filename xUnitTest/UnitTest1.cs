using System;
using Geometry;
using Geometry.Strategy;
using Xunit;

namespace xUnitTest;

public class UnitTest1
{
    [Fact]
    public void TestCircle()
    {
        // Arrange
        var calculator = new Calculate();
        
        //Act
        calculator.SetFigure(new Circle(25));
        var result = calculator.GetSquareFigure();

        // Assert
        Assert.Equal(1963.50,  Math.Round(result,2));
    }
    [Fact]
    public void TestTriangle()
    {
        // Arrange
        var calculator = new Calculate();
        
        //Act
        calculator.SetFigure(new Triangle(24,25,7));
        var result = calculator.GetSquareFigure();

        // Assert
        Assert.Equal(84,  Math.Round(result,2));
    }
}