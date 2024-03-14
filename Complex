using System;

class Complex
{
    private double real;
    private double imaginary;

    public Complex(double real, double imaginary)
    {
        this.real = real;
        this.imaginary = imaginary;
    }

    // Overloaded '+' operator for adding two complex numbers
    public static Complex operator +(Complex c1, Complex c2)
    {
        double realSum = c1.real + c2.real;
        double imaginarySum = c1.imaginary + c2.imaginary;
        return new Complex(realSum, imaginarySum);
    }

    public override string ToString()
    {
        return $"{real} + {imaginary}i";
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first complex number:");
        Complex complex1 = ReadComplexNumber();

        Console.WriteLine("Enter the second complex number:");
        Complex complex2 = ReadComplexNumber();

        // Add two complex numbers using the overloaded '+' operator
        Complex result = complex1 + complex2;

        Console.WriteLine($"Result of addition: {complex1} + {complex2} = {result}");
    }

    static Complex ReadComplexNumber()
    {
        Console.Write("Enter the real part: ");
        double realPart = double.Parse(Console.ReadLine());

        Console.Write("Enter the imaginary part: ");
        double imaginaryPart = double.Parse(Console.ReadLine());

        return new Complex(realPart, imaginaryPart);
    }
}
