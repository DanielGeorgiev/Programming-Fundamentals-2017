using System;
public class GeometryCalculactor
{
    public static void Main()
    {
        string figureType = Console.ReadLine();

        if (figureType == "triangle" || figureType == "rectangle")
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            CalculateFigures(a, b, figureType);
        }
        else if (figureType == "circle" || figureType == "square")
        {
            double a = double.Parse(Console.ReadLine());

            CalculateFigures(a, figureType);
        }
    }

    public static void CalculateFigures(double a, string figureType)
    {
        double area = 0;

        if (figureType == "circle")
        {
            area = Math.PI * Math.Pow(a, 2);
        }
        else
        {
            area = a * a;
        }

        Console.WriteLine("{0:f2}", area);
    }

    public static void CalculateFigures(double a, double b, string figureType)
    {
        double area = 0;

        if (figureType == "triangle")
        {
            area = a * b / 2.0;
        }
        else
        {
            area = a * b;
        }

        Console.WriteLine("{0:f2}", area);
    }
}

