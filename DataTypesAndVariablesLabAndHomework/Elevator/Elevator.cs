using System;
class Elevator
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        uint p = uint.Parse(Console.ReadLine());
        double courses = (double)n / p;

        Console.WriteLine(Math.Ceiling(courses));
    }
}

