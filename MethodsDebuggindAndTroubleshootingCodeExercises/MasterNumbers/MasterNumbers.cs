using System;
using System.Linq;
public class MasterNumbers
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        FindMasterNumber(number);
    }

    public static void FindMasterNumber(int number)
    {
        for (int currentNumber = 1; currentNumber <= number; currentNumber++)
        {
            if (IsPalindrome(currentNumber) && IsDigitsDivisibleBy7(currentNumber) && IsDigitEven(currentNumber))
            {
                Console.WriteLine(currentNumber);
            }
        }
    }

    public static bool IsPalindrome(int number)
    {
        bool isPalindrome = false;

        int reversedNumber = 0;
        int numberForReverse = number;

        while (numberForReverse > 0)
        {
            int r = numberForReverse % 10;
            reversedNumber = reversedNumber * 10 + r;
            numberForReverse /= 10;
        }

        if (number == reversedNumber)
        {
            isPalindrome = true;
        }

        return isPalindrome;
    }

    public static bool IsDigitsDivisibleBy7(int number)
    {
        bool IsDigitsDivisibleBy7 = false;

        int digitsSum = 0;

        while (number > 0)
        {
            digitsSum += number % 10;
            number /= 10;
        }

        if (digitsSum % 7 == 0)
        {
            IsDigitsDivisibleBy7 = true;
        }

        return IsDigitsDivisibleBy7;
    }

    public static bool IsDigitEven(int number)
    {
        bool isDigitEven = false;
        int digit = 0;

        while (number > 0)
        {
            digit = number % 10;
            number /= 10;

            if (digit % 2 == 0)
            {
                isDigitEven = true;
                break;
            }
        }

        return isDigitEven;
    }
}

