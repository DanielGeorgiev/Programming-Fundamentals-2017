using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public class Rectangle
    {
        public int Left { get; set; }
        public int Top { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Bottom
        {
            get
            {
                return Top + Height;
            }
        }
        public int Right
        {
            get
            {
                return Left + Width;
            }
        }

        public static Rectangle ToRectangle(int[] numbers)
        {
            var rectangle = new Rectangle()
            {
                Left = numbers[0],
                Top = numbers[1],
                Width = numbers[2],
                Height = numbers[3],
            };

            return rectangle;
        }
    }

    public static void Main()
    {
        var line1 = Console.ReadLine()
            .Split()
            .Select(int.Parse).ToArray();

        var line2 = Console.ReadLine()
            .Split()
            .Select(int.Parse).ToArray();

        var rectangle1 = Rectangle.ToRectangle(line1);
        var rectangle2 = Rectangle.ToRectangle(line2);

        if (!IsInside(rectangle1, rectangle2))
        {
            Console.WriteLine("Not inside");
        }
        else
        {
            Console.WriteLine("Inside");
        }
    }

    public static bool IsInside(Rectangle rectangle1, Rectangle rectangle2)
    {
        if ((rectangle1.Left >= rectangle2.Left) && (rectangle1.Right <= rectangle2.Right) && (rectangle1.Height <= rectangle2.Height) && (rectangle1.Top <= rectangle2.Top))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

