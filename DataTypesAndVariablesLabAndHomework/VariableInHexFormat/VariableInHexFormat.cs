using System;
class VariableInHexFormat
{
    static void Main()
    {
        string numberInHexadecimal = Console.ReadLine();
        int numberInDecimal = Convert.ToInt32(numberInHexadecimal, 16);

        Console.WriteLine(numberInDecimal);
    }
}

