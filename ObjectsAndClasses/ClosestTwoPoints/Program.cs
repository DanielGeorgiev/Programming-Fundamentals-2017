using System;
using System.Collections.Generic;
using System.Linq;
public class Program
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

        public static void FindClosestTwoPoints(List<Point> points)
        {
            var minValue = double.MaxValue;
            var point1 = new Point();
            var point2 = new Point();

            for (int i = 0; i < points.Count; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    var distance = CalculateDistance(points[i], points[j]);

                    if (distance < minValue)
                    {
                        minValue = distance;
                        point1 = points[i];
                        point2 = points[j];
                    }
                }
            }

            Console.WriteLine("{0:f3}", minValue);
            Console.WriteLine("({0}, {1})", point1.X, point1.Y);
            Console.WriteLine("({0}, {1})", point2.X, point2.Y);
        }
    }

    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var points = new List<Point>();

        for (int i = 0; i < n; i++)
        {
            var line = Console.ReadLine()
                .Split()
                .Select(int.Parse).ToArray();

            var point = new Point()
            {
                X = line[0],
                Y = line[1]
            };

            points.Add(point);
        }

        Point.FindClosestTwoPoints(points);
    }
}

