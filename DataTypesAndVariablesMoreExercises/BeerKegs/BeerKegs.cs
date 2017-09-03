using System;
class BeerKegs
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double currentVolume = 0;
        double max = 0;
        string biggestKegModel = string.Empty;

        for (int i = 1; i <= n; i++)
        {
            string model = Console.ReadLine();
            double radius = double.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            currentVolume = Math.PI * Math.Pow(radius, 2) * height;

            if (currentVolume > max)
            {
                biggestKegModel = string.Empty;
                max = currentVolume;
                biggestKegModel += model;
            }
        }

        Console.WriteLine(biggestKegModel);
    }
}

