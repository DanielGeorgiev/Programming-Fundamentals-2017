using System;
public class FibonacciNumbers
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Fibonacci(n));
    }

    public static int Fibonacci(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else if (n == 1)
        {
            return 1;
        }
        else if (n == 2)
        {
            return 2;
        }

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}

