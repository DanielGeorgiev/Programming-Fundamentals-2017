using System;
using System.Linq;
public class NumbersInReversedOrder
{
    public static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        Console.WriteLine(ReverseNumber(number));
    }

    public static string ReverseNumber(double number)
    {
        string numberAsString = number.ToString();
        return string.Join("", numberAsString.Reverse());
    }
}

