using System;
class sub
{
    static void Main()
    {
        Console.WriteLine("Enter the string:");
        string s=Console.ReadLine();
        int len = s.Length;
        Console.WriteLine("Length=");
        Console.WriteLine(len);
        Console.WriteLine("substrings:");
        for(int i = 0; i < len; i++)
        {
            for(int j = i + 1; j <= len; j++)
            {
                string v=s.Substring(i, j-i);
                Console.WriteLine(v);
            }
        }
            
        
    }
}