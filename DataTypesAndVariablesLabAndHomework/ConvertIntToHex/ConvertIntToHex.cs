using System;
class ConvertIntToHex
{
    static void Main()
    {
        int intNumber = int.Parse(Console.ReadLine());
        string hexadecNumber = Convert.ToString(intNumber, 16).ToUpper();
        string binaryNumber = Convert.ToString(intNumber, 2);

        Console.WriteLine(hexadecNumber);
        Console.WriteLine(binaryNumber);
    }
}

