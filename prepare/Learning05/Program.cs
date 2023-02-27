using System;

class Program
{
    static void Main(string[] args)
    {

        List<Shape> shapes = new List<Shape>();
        Square s = new Square("Green", 10);
        shapes.Add(s);

        Rectangle r = new Rectangle("Red", 5, 10);
        shapes.Add(r);

        Circle c = new Circle("Green", 1);
        shapes.Add(c);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }


    }
}