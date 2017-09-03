using System;
public class CubeProperties
{
    public static void Main()
    {
        double side = double.Parse(Console.ReadLine());
        string property = Console.ReadLine();
        FindCubeProperties(Math.Abs(side), property);
    }

    public static void FindCubeProperties(double side, string property)
    {
        double result = 0;

        if (property == "face")
        {
            result = Math.Sqrt(2 * Math.Pow(side, 2));
        }
        else if (property == "space")
        {
            result = Math.Sqrt(3 * Math.Pow(side, 2));
        }
        else if (property == "volume")
        {
            result = Math.Pow(side, 3);
        }
        else if (property == "area") 
        {
            result = 6 * Math.Pow(side, 2);
        }

        Console.WriteLine("{0:f2}", result);
    }
}

