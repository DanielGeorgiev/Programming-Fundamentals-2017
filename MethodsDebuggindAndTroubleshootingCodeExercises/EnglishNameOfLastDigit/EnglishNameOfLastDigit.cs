using System;
public class EnglishNameOfLastDigit
{
    public static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        Console.WriteLine(GetNameOfLastDigit(Math.Abs(number)));
    }

    public static string GetNameOfLastDigit(long number)
    {
        if (number % 10 == 0)
        {
            return "zero";
        }
        else if (number % 10 == 1)
        {
            return "one";
        }
        else if (number % 10 == 2)
        {
            return "two";
        }
        else if (number % 10 == 3)
        {
            return "three";
        }
        else if (number % 10 == 4)
        {
            return "four";
        }
        else if (number % 10 == 5)
        {
            return "five";
        }
        else if (number % 10 == 6)
        {
            return "six";
        }
        else if (number % 10 == 7)
        {
            return "seven";
        }
        else if (number % 10 == 8)
        {
            return "eight";
        }
        else 
        {
            return "nine";
        }
    }
}

