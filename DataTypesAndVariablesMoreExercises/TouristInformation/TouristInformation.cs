using System;
class TouristInformation
{
    static void Main()
    {
        string imperialUnit = Console.ReadLine();
        double value = double.Parse(Console.ReadLine());

        UnitConverter(imperialUnit, value);
    }

    public static void UnitConverter(string unit, double value)
    {
        string convertedUnit = string.Empty;
        double saveValue = value;

        if (unit == "miles")
        {
            value *= 1.6;
            convertedUnit = "kilometers";
        }
        else if (unit == "inches")
        {
            value *= 2.54;
            convertedUnit = "centimeters";
        }
        else if (unit == "feet")
        {
            value *= 30;
            convertedUnit = "centimeters";
        }
        else if (unit == "yards")
        {
            value *= 0.91;
            convertedUnit = "meters";
        }
        else if (unit == "gallons")
        {
            value *= 3.8;
            convertedUnit = "liters";
        }

        Console.WriteLine("{0} {1} = {2:f2} {3}", saveValue, unit, value, convertedUnit);
    }
}

