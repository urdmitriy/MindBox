// See https://aka.ms/new-console-template for more information
using Geometry;
using Geometry.Strategy;

var calculator = new Calculate();

calculator.GetSquareFigure();

calculator.SetFigure(new Circle(25));
calculator.GetSquareFigure();

calculator.SetFigure(new Triangle(10, 12, 15));
calculator.GetSquareFigure();

calculator.SetFigure(new Triangle(24, 25, 7));
calculator.GetSquareFigure();
