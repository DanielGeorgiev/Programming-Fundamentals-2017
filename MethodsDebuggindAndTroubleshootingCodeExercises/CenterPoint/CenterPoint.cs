using System;
public class CenterPoint
{
    public static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        FindCenterPoint(x, y, x1, y1);
    }

    public static void FindCenterPoint(double x, double y, double x1, double y1)
    {
        if (Math.Abs(x) + Math.Abs(y) <= Math.Abs(x1) + Math.Abs(y1))
        {
            Console.WriteLine("({0}, {1})", x, y);
        }
        else if (Math.Abs(x) + Math.Abs(y) > Math.Abs(x1) + Math.Abs(y1))
        {
            Console.WriteLine("({0}, {1})", x1, y1);
        }
    }
}

