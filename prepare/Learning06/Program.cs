using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("blue", 5));
        shapes.Add(new Rectangle("red", 10, 20));
        shapes.Add(new Circle("yellow", 5));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"{shape.GetColor()}\n{shape.GetArea()}");
        }
    }
}