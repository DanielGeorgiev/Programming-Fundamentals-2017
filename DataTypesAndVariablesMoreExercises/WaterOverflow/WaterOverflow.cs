using System;
class WaterOverflow
{
    static void Main()
    {
        byte count = byte.Parse(Console.ReadLine());
        short waterTank = 255;
        short totalWater = 0;


        for (int i = 1; i <= count; i++)
        {
            short liters = short.Parse(Console.ReadLine());

            if (liters <= waterTank)
            {
                waterTank -= liters;
                totalWater += liters;
            }
            else
            {
                Console.WriteLine("Insufficient capacity!");
            }
        }

        Console.WriteLine(totalWater);

    }
}

