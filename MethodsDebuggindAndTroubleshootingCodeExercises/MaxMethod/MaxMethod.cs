using System;
public class MaxMethod
{
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (a > MaxNumber(b,c))
        {
            Console.WriteLine(a);
        }
        else
        {
            Console.WriteLine(MaxNumber(b,c));
        }
    }

    public static int MaxNumber(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
}

