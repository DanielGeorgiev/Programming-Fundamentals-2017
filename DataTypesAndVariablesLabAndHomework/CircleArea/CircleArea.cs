using System;
class CircleArea
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());
        double area = Math.PI * Math.Pow(r, 2);
        Console.WriteLine("{0:f12}", area);
    }
}

