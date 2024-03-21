using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        int rows = random.Next(6, 10);
        int[][] jaggedArray = new int[rows][];

        for (int i = 0; i < rows; i++)
        {
            jaggedArray[i] = new int[i + 1];

            for (int j = 0; j <= i; j++)
            {
                jaggedArray[i][j] = random.Next(100);
            }
        }

        Console.WriteLine("The Floyd's triangle is:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
        }

        double[] rowAverages = new double[rows];
        double[] colAverages = new double[rows];
        double arrayAverage = 0;
        int count = 0;

        for (int i = 0; i < rows; i++)
        {
            double rowSum = 0;
            for (int j = 0; j <= i; j++)
            {
                rowSum += jaggedArray[i][j];
                colAverages[j] += jaggedArray[i][j];
                arrayAverage += jaggedArray[i][j];
                count++;
            }
            rowAverages[i] = rowSum / (i + 1);
        }

        for (int i = 0; i < rows; i++)
        {
            colAverages[i] /= (i + 1);
        }

        arrayAverage /= count;

        Console.WriteLine("The array average is: " + arrayAverage);

        Console.WriteLine("The row averages are:");
        for (int i = 0; i < rows; i++)
        {
            Console.WriteLine("Row " + i + ": " + rowAverages[i]);
        }

        Console.WriteLine("The column averages are:");
        for (int i = 0; i < rows; i++)
        {
            Console.WriteLine("Column " + i + ": " + colAverages[i]);
        }

        Console.WriteLine("The values above the array average are:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                if (jaggedArray[i][j] > arrayAverage)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
            }
        }
        Console.WriteLine();

        Console.WriteLine("The values below the array average are:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                if (jaggedArray[i][j] < arrayAverage)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
            }
        }
        Console.WriteLine();
    }
}