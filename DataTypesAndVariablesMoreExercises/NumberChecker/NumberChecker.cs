using System;
class NumberChecker
{
    static void Main()
    {
        string value = Console.ReadLine();

        ulong integerNumber;
        float floatingPointNumber;

        bool isInteger = ulong.TryParse(value, out integerNumber);
        bool isFloat = float.TryParse(value, out floatingPointNumber);

        if (isInteger)
        {
            Console.WriteLine("integer");
        }
        else
        {
            Console.WriteLine("floating-point");
        }
    }
}

