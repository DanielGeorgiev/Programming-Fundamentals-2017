using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        long m = long.Parse(Console.ReadLine());
        long y = long.Parse(Console.ReadLine());

        long saveN = n;
        long targetsPoked = 0;

        while (n > m)
        {
            n -= m;
            targetsPoked++;

            if (n == saveN / 2 && y != 0)
            {
                n /= y;
            }
        }

        Console.WriteLine(n);
        Console.WriteLine(targetsPoked);
    }
}

