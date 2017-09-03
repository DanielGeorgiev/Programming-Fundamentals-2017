using System;
using System.Collections.Generic;
using System.Linq;
public class ImmuneSystem
{
    //UNFINISHED
    public static void Main()
    {
        var health = int.Parse(Console.ReadLine());
        var virus = Console.ReadLine();

        while (virus != "end")
        {
            int virusStrength = virus.Select(x => (int)x).Sum() / 3;
            int timeToDefeat = virusStrength * virus.Length;
        }
    }
}

