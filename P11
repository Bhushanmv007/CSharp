using System;

abstract class Shape
{
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
}

class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * radius;
    }
}

class Triangle : Shape
{
    private double sideA, sideB, sideC;

    public Triangle(double sideA, double sideB, double sideC)
    {
        this.sideA = sideA;
        this.sideB = sideB;
        this.sideC = sideC;
    }

    public override double CalculateArea()
    {
        double s = (sideA + sideB + sideC) / 2;
        return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
    }

    public override double CalculatePerimeter()
    {
        return sideA + sideB + sideC;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the dimensions of the circle:");
        Console.Write("Enter the radius: ");
        double circleRadius = double.Parse(Console.ReadLine());

        Console.WriteLine("\nEnter the dimensions of the triangle:");
        Console.Write("Enter the length of side A: ");
        double triangleSideA = double.Parse(Console.ReadLine());

        Console.Write("Enter the length of side B: ");
        double triangleSideB = double.Parse(Console.ReadLine());

        Console.Write("Enter the length of side C: ");
        double triangleSideC = double.Parse(Console.ReadLine());

        Circle circle = new Circle(circleRadius);
        Triangle triangle = new Triangle(triangleSideA, triangleSideB, triangleSideC);

        DisplayShapeDetails(circle, "Circle");
        DisplayShapeDetails(triangle, "Triangle");
    }

    static void DisplayShapeDetails(Shape shape, string shapeName)
    {
        Console.WriteLine($"\n{shapeName} Details:");
        Console.WriteLine($"Area: {shape.CalculateArea()}");
        Console.WriteLine($"Perimeter: {shape.CalculatePerimeter()}");
    }
}
