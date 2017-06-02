using System;
class ConvertSpeedUnits
{
    static void Main()
    {
        int distanceInMeters = int.Parse(Console.ReadLine());
        byte hours = byte.Parse(Console.ReadLine());
        byte minutes = byte.Parse(Console.ReadLine());
        byte seconds = byte.Parse(Console.ReadLine());

        float totalSeconds = hours * 60 * 60 + minutes * 60 + seconds;
        float metersPerSecond = distanceInMeters / totalSeconds;
        Console.WriteLine(metersPerSecond);

        float totalHours = totalSeconds / 60 / 60;
        float kilometersPerHour = (distanceInMeters / 1000) / totalHours;
        Console.WriteLine(kilometersPerHour);

        float milesPerHour = (distanceInMeters / 1609.0f) / totalHours;
        Console.WriteLine(milesPerHour);
    }
}

