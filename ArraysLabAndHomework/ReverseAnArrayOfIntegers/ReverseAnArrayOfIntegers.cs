using System;
class ReverseAnArrayOfIntegers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var numbersArray = new int[n];

        for (int i = numbersArray.Length - 1; i >= 0; i--)
        {
            int number = int.Parse(Console.ReadLine());
            numbersArray[i] = number;
        }

        for (int i = 0; i < numbersArray.Length; i++)
        {
            Console.Write("{0} ", numbersArray[i]);
        }
    }
}

