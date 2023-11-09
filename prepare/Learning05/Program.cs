using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> figures = new List<Shape>();
        Square square = new Square();
        square.SetColor("blue");
        square.Set(4);
        Rectangle rectangle = new Rectangle();
        rectangle.Set(2,4);
        // Create different kinds of employees and add them to the same list
        figures.Add(square);
        figures.Add(rectangle);

// Get a custom calculation for each one
foreach(Shape employee in figures)
{
  double area = employee.GetArea();
  Console.WriteLine(area);
}
    }
}