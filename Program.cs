using System;

abstract class Shape
{
    public string Name { get; set; }

    public Shape(string name)
    {
        Name = name;
    }

    public abstract double Area();
    public abstract double Perimeter();
}

class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(string name, double radius) : base(name)
    {
        Radius = radius;
    }

    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }

    public override double Perimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

class Square : Shape
{
    public double Side { get; set; }

    public Square(string name, double side) : base(name)
    {
        Side = side;
    }

    public override double Area()
    {
        return Side * Side;
    }

    public override double Perimeter()
    {
        return 4 * Side;
    }
}

class Program
{
    static void Main()
    {
        Circle circle1 = new Circle("Circle 1", 5.0);
        Circle circle2 = new Circle("Circle 2", 3.0);

        Square square1 = new Square("Square 1", 4.0);
        Square square2 = new Square("Square 2", 6.0);

        // a) Вивести назву, площу та периметр усіх фігур.
        DisplayShapeInfo(circle1);
        DisplayShapeInfo(circle2);
        DisplayShapeInfo(square1);
        DisplayShapeInfo(square2);

        // b) Вивести на екран площу найбільшого квадрата та найбільшого кола.
        Square largestSquare = GetLargestSquare(square1, square2);
        Circle largestCircle = GetLargestCircle(circle1, circle2);

        Console.WriteLine($"Площа найбільшого квадрата ({largestSquare.Name}): {largestSquare.Area()}");
        Console.WriteLine($"Площа найбільшого кола ({largestCircle.Name}): {largestCircle.Area()}");
    }

    static void DisplayShapeInfo(Shape shape)
    {
        Console.WriteLine($"Фігура: {shape.Name}");
        Console.WriteLine($"Площа: {shape.Area()}");
        Console.WriteLine($"Периметр: {shape.Perimeter()}");
        Console.WriteLine();
    }

    static Square GetLargestSquare(Square square1, Square square2)
    {
        return square1.Area() >= square2.Area() ? square1 : square2;
    }

    static Circle GetLargestCircle(Circle circle1, Circle circle2)
    {
        return circle1.Area() >= circle2.Area() ? circle1 : circle2;
    }
}

