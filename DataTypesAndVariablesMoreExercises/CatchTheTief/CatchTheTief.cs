using System;
class CatchTheTief
{
    static void Main()
    {
        string numeralType = Console.ReadLine();
        int count = int.Parse(Console.ReadLine());
        long currentNumber = 0;

        for (int i = 0; i < count; i++)
        {
            long number = long.Parse(Console.ReadLine());

            if (numeralType == "sbyte" && number >= -128 && number <= 127)
            {
                if (i == 0)
                {
                    currentNumber = -128;
                }

                if (number > currentNumber)
                {
                    currentNumber = number;
                }
            }

            else if (numeralType == "int" && number >= int.MinValue && number <= int.MaxValue)
            {
                if (i == 0)
                {
                    currentNumber = int.MinValue;
                }
                if (number > currentNumber)
                {
                    currentNumber = number;
                }
            }

            else if (numeralType == "long" && number >= long.MinValue && number <= long.MaxValue)
            {
                if (i == 0)
                {
                    currentNumber = long.MinValue;
                }
                if (number > currentNumber)
                {
                    currentNumber = number;
                }
            }
        }

        Console.WriteLine(currentNumber);
    }
}

