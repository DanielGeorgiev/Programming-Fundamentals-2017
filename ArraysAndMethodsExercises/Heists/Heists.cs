using System;
using System.Linq;
using System.Collections.Generic;
public class Heists
{
    public static void Main()
    {
        var jewelsAndGold = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(long.Parse)
            .ToArray();

        long totalEarnings = 0;
        long totalExpenses = 0;

        while (true)
        {
            var lootAndHeistExpenses = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            if (lootAndHeistExpenses[0] != "Jail" && lootAndHeistExpenses[1] != "Time")
            {
                totalExpenses += int.Parse(lootAndHeistExpenses[1]);

                for (int i = 0; i < lootAndHeistExpenses[0].Length; i++)
                {
                    if (lootAndHeistExpenses[0][i] == '%')
                    {
                        totalEarnings += jewelsAndGold[0];
                    }
                    else if (lootAndHeistExpenses[0][i] == '$')
                    {
                        totalEarnings += jewelsAndGold[1];      
                    }
                }
            }

            else
            {
                {
                    if (totalEarnings >= totalExpenses)
                    {
                        Console.WriteLine("Heists will continue. Total earnings: {0}.", totalEarnings - totalExpenses);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Have to find another job. Lost: {0}.", totalExpenses - totalEarnings);
                        break;
                    }
                }
            }
        }
    }
}

