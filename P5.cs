using System;

class PascalTriangle
{
    static void Main()
    {
        Console.WriteLine("Pascal's Triangle (Equilateral)");

        int rows = 5;

        for (int i = 0; i < rows; i++)
        {
            // Print leading spaces
            for (int blank = 0; blank < rows - i - 1; blank++)
            {
                Console.Write("   ");
            }

            int val = 1;
            for (int j = 0; j <= i; j++)
            {
                // Print the current value in Pascal's Triangle
                Console.Write($"{val,3}");

                // Adjust spacing for equilateral triangle
                Console.Write("   ");

                // Calculate the next value
                val = val * (i - j) / (j + 1);
            }

            Console.WriteLine(); // Move to the next line after each row
        }
    }
}
