using System;
using System.Numerics;
public class FactorialTrailingZeroes
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(FindFactorialTrailingZeroes(number));
    }

    public static int FindFactorialTrailingZeroes(int number)
    {
        BigInteger factorial = FindFactorial(number);
        int count = 0;

        while (factorial % 10 == 0)
        {
            count++;
            factorial /= 10;
        }

        return count;
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

