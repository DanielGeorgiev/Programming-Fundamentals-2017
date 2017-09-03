using System;
public class PrimeChecker
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(IsPrime(number));
    }

    public static bool IsPrime(int number)
    {
        bool isPrime = true;

        if (number == 0)
        {
            return false;
        }
        else if (number == 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        return isPrime;
    }
}

