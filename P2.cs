using System;
class arms
{
    static void Main()
    {
        Console.WriteLine("Armstrong num from 1 to 1000");
        for(int i = 1; i <= 1000; i++)
        {
            if (isArms(i))
                Console.WriteLine(i);
        }
    }
    static bool isArms(int num)
    {
        int onum = num, rem, res = 0;
        int n = onum.ToString().Length;
        while(onum!=0)
        {
            rem= onum%10;
            res += (int)Math.Pow(rem, n);
            onum /=10;
        }
        return res == num;
    }
}
