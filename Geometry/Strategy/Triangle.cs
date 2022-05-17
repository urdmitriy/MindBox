using System.Threading.Channels;

namespace Geometry.Strategy;

public class Triangle : IFigure
{
    private readonly double _side1;
    private readonly double _side2;
    private readonly double _side3;

    public Triangle(double side1, double side2, double side3)
    {
        _side1 = side1;
        _side2 = side2;
        _side3 = side3;
    }
    public double GetSquare()
    {
        var p = (_side1 + _side2 + _side3) / 2;
        var s = Math.Sqrt(p * (p - _side1) * (p - _side2) * (p - _side3));
        Console.Write($@"Площадь треугольника со сторонами {_side1},{_side2},{_side3} равна {s:F}");
        if (IsTriangleRectangular())
        {
            Console.Write(", этот треугольник прямоугольный");
        }
        Console.Write(Environment.NewLine);
        return s;
    }

    private bool IsTriangleRectangular()
    {
        double gipotenuza, katet1, katet2;
        if (_side1 > _side2 && _side1 > _side3)
        {
            //side1 max
            gipotenuza = _side1;
            katet1 = _side2;
            katet2 = _side3;
        }
        else if (_side1 > _side2 && _side1 < _side3)
        {
            //side3 max
            gipotenuza = _side3;
            katet1 = _side1;
            katet2 = _side2;
        }
        else
        {
            //side2 max
            gipotenuza = _side2;
            katet1 = _side1;
            katet2 = _side3;
        }

        return Math.Pow(gipotenuza, 2) == Math.Pow(katet1, 2) + Math.Pow(katet2, 2);
    }
}