using System;
public class LongerLine
{
    public static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double x3 = double.Parse(Console.ReadLine());
        double y3 = double.Parse(Console.ReadLine());
        double x4 = double.Parse(Console.ReadLine());
        double y4 = double.Parse(Console.ReadLine());

        FindLongerLine(x1, y1, x2, y2, x3, y3, x4, y4);
    }

    public static void FindLongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
    {
        double firstLine = Math.Abs(y1) + Math.Abs(y2);
        double secondLine = Math.Abs(y3) + Math.Abs(y4);

        if (firstLine >= secondLine)
        {
            FindCenterPoint(x1, y1, x2, y2);
        }
        else
        {
            FindCenterPoint(x3, y3, x4, y4);
        }
    }

    public static void FindCenterPoint(double x1, double y1, double x2, double y2)
    {
        if (Math.Abs(x1) + Math.Abs(y1) <= Math.Abs(x2) + Math.Abs(y2))
        {
            Console.Write("({0}, {1})", x1, y1);
            Console.WriteLine("({0}, {1})", x2, y2);
        }
        else if (Math.Abs(x1) + Math.Abs(y1) > Math.Abs(x2) + Math.Abs(y2))
        {
            Console.Write("({0}, {1})", x2, y2);
            Console.WriteLine("({0}, {1})", x1, y1);
        }
    }
}

