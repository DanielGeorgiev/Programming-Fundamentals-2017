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
    }
    public class Circle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Radius { get; set; }

        public static bool Intersect(Circle circle1, Circle circle2)
        {
            var point1 = new Point()
            {
                X = circle1.X,
                Y = circle1.Y
            };

            var point2 = new Point()
            {
                X = circle2.X,
                Y = circle2.Y
            };

            var distanceBetweenPoints = Point.CalculateDistance(point1, point2);

            if (circle1.Radius + circle2.Radius >= distanceBetweenPoints)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public static void Main()
    {
        var input1 = Console.ReadLine()
            .Split().Select(int.Parse).ToArray();
        var input2 = Console.ReadLine()
            .Split().Select(int.Parse).ToArray();

        var c1 = new Circle()
        {
            X = input1[0],
            Y = input1[1],
            Radius = input1[2]
        };

        var c2 = new Circle()
        {
            X = input2[0],
            Y = input2[1],
            Radius = input2[2]
        };

        if (Circle.Intersect(c1, c2))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

