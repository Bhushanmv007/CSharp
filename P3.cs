using System;
class sub
{
    static void Main()
    {
        Console.WriteLine("Enter the string: ");
        string ipstring=Console.ReadLine();

        Console.WriteLine("All substrings are: ");
        for(int i = 0; i < ipstring.Length; i++)
        {
            for(int j=i+1;j<=ipstring.Length;j++)
            {
                string sub=ipstring.Substring(i,j-i);
                Console.WriteLine(sub);
            }
        }
    }
}
