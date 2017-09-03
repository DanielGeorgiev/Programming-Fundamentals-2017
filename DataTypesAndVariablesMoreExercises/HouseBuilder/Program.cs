using System;
class HouseBuilder
{
    static void Main()
    {
        long firstPrice = long.Parse(Console.ReadLine());
        long secondPrice = long.Parse(Console.ReadLine());

        ulong total = 0;

        if (firstPrice >= 128)
        {
            total = (ulong)(firstPrice * 10 + secondPrice * 4);
        }
        else
        {
            total = (ulong)(firstPrice * 4 + secondPrice * 10);
        }

        Console.WriteLine(total);
    }
}

