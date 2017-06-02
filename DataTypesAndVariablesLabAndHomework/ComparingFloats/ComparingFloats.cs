using System;
class ComparingFloats
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        double difference = Math.Abs(b - a);
        double eps = 0.000001;

        if (difference <= eps)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}

