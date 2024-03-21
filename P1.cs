using System;
class calc
{
    static void main()
    {
        float res;
        Console.WriteLine("Enter 1st number:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the 2nd number:");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter operator: ");
        string op = Convert.ToString(Console.ReadLine());
        switch(op)
        {
            case "+": Console.WriteLine("res ="+(x+y)); 
                break;
            case "-": Console.WriteLine("res =" + (x - y));
                break;
            case "*": Console.WriteLine("res ="+(x*y));
                break;
            case "/":
                if (y != 0)
                {
                    Console.WriteLine("res =" + (x / y));
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                    break;
                }
            case "%": 
                if(y != 0)
                {
                    Console.WriteLine("res =" + (x % y));
                    break;
                }
                else
                {
                    Console.WriteLine("invalid input");
                    break;
                }                
        }
    }
}
