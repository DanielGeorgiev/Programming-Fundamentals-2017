using System;
using System.Numerics;

public class Factorial
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(FindFactorial(number));
    }

    public static BigInteger FindFactorial(int number)
    {
        BigInteger factorial = 1;

        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        return factorial;
    }
}

