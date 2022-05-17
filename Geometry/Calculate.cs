using Geometry.Strategy;

namespace Geometry;
/// <summary>
/// Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и
/// треугольника по трем сторонам.
/// Дополнительно к работоспособности оценим:
/// - Юнит-тесты
/// - Легкость добавления других фигур
/// - Вычисление площади фигуры без знания типа фигуры в compile-time
/// - Проверку на то, является ли треугольник прямоугольным
/// </summary>
public class Calculate
{
    private IFigure _figure;

    public void SetFigure(IFigure figure)
    {
        _figure = figure;
    }

    public Calculate()
    {
        
    }
    public double GetSquareFigure()
    {
        if (_figure is null)
        {
            Console.WriteLine("Не указана фигура");
            return 0;
        }
        var result = _figure.GetSquare();
        return result;
    }
}