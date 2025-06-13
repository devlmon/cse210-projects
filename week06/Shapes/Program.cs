using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapeList = new List<Shape>();
        shapeList.Add(new Square("Black", 5.2));
        shapeList.Add(new Rectangle("Red", 4.3, 2.1));
        shapeList.Add(new Circle("White", 3.4));

        foreach (Shape shape in shapeList)
        {
            Console.WriteLine($"Color: {shape.GetColor()}. Area: {shape.GetArea()}");
        }
    }
}