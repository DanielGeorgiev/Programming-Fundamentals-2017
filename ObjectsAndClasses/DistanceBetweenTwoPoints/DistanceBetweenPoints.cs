using System;
using System.Collections.Generic;
using System.Linq;
public class DistanceBetweenPoints
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static double CalculateDistance(Point p1, Point p2)
        {
            var a = p1.X - p2.X;
            var b = p1.Y - p2.Y;
            var c = Math.Pow(a, 2) + Math.Pow(b, 2);

            return Math.Sqrt(c);
        }
    }

    public static void Main()
    {
        var p1 = Console.ReadLine()
            .Split().Select(int.Parse).ToArray();

        var point1 = new Point()
        {
            X = p1[0],
            Y = p1[1]
        };

        var p2 = Console.ReadLine()
            .Split().Select(int.Parse).ToArray();

        var point2 = new Point()
        {
            X = p2[0],
            Y = p2[1]
        };

        Console.WriteLine("{0:f3}", Point.CalculateDistance(point1, point2));
    }
}

