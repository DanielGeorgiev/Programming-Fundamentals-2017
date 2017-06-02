using System;
class RectangleProperties
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        double perimeter = (a + b) * 2;
        double area = a * b;
        double diagonal = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

        Console.WriteLine(perimeter);
        Console.WriteLine(area);
        Console.WriteLine(diagonal);
    }
}
