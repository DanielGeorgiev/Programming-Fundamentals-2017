using System;
class WeatherForecast
{
    static void Main()
    {
        string number = Console.ReadLine();

        sbyte sunny;
        int cloudy;
        long windy;
        float rainy;

        bool isSunny = sbyte.TryParse(number, out sunny);
        bool isCloudy = int.TryParse(number, out cloudy);
        bool isWindy = long.TryParse(number, out windy);
        bool isRainy = float.TryParse(number, out rainy);

        if (isSunny)
        {
            Console.WriteLine("Sunny");
        }
        else if (isCloudy)
        {
            Console.WriteLine("Cloudy");
        }
        else if (isWindy)
        {
            Console.WriteLine("Windy"); 
        }
        else if (isRainy)
        {
            Console.WriteLine("Rainy");
        }
    }
}

