using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main()
    {
        int teamsCount = int.Parse(Console.ReadLine());

        var dict = new Dictionary<string, string>();

        for (int i = 0; i < teamsCount; i++)
        {
            var input = Console.ReadLine()
                .Split('-').ToArray();
            var user = input[0];
            var teamName = input[1];

            if (!dict.ContainsKey(user))
            {
                if (!dict.ContainsValue(teamName))
                {
                    dict[user] = teamName;
                    Console.WriteLine("Team {0} has been created by {1}!", teamName, user);
                }
                else
                {
                    Console.WriteLine("Team {0} was already created!", teamName);
                }
            }
            else
            {
                Console.WriteLine("{0} cannot create another team!", user);
            }
        }
    }
}

