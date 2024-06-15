using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Black", 5);
        shapes.Add(s1);

        Rectangle r1 = new Rectangle("Grey", 6, 3);
        shapes.Add(r1);

        Circle c1 = new Circle("Brown", 6);
        shapes.Add(c1);

        foreach (Shape s in shapes) {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine("The " + color + "shape has an area of " + area + ".");
        }
    }
}