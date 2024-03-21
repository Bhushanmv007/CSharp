using System;

class ExceptionProgram
{
    static void Main()
    {
        Console.WriteLine("Enter the first number: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        int y = Convert.ToInt32(Console.ReadLine());

        try
        {
            int result = x / y;
            Console.WriteLine("Result is " + result);
        }
        catch (Exception)
        {
            Console.WriteLine("Division by zero is invalid, provide another input");
        }

        Console.WriteLine("Enter the size of array: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter elements:");
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)  
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Enter the index:");
        int pos = Convert.ToInt32(Console.ReadLine());

        try
        {
            Console.WriteLine(arr[pos]);
        }
        catch (Exception)
        {
            Console.WriteLine("Index out of bounds");
        }
    }
}
