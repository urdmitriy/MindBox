namespace Geometry.Strategy;

public class Circle: IFigure
{
    private readonly double _radius;
    public Circle(double radius)
    {
        _radius = radius;
    }
    
    public double GetSquare()
    {
        var result = Math.PI * Math.Pow(_radius, 2);
        Console.WriteLine($@"Площадь круга радиусом {_radius} равна {result:F}");
        return result;
    }
}