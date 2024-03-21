using System;
using System.IO;
class FileCopy
{
    static void Main()
    {
        Console.WriteLine("Enter the source file path");
        string source=Console.ReadLine();
        Console.WriteLine("Enter the destination file path");
        string dest = Console.ReadLine();
        try
        {
            string filecontents = File.ReadAllText(source);
            File.WriteAllText(dest, filecontents);
            Console.WriteLine("file copied");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"error occured {ex.Message}");
        }
    }
}