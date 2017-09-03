using System;
using System.Collections.Generic;
using System.Linq;
public class PhonebookUpgrade
{
    public static void Main()
    {
        var commands = Console.ReadLine()
            .Split()
            .ToList();
        var contacts = new SortedDictionary<string, string>();


        while (commands[0] != "END")
        {
            if (commands[0] == "A")
            {
                string name = commands[1];
                string phoneNumber = commands[2];
                contacts[name] = phoneNumber;
            }

            if (commands[0] == "ListAll")
            {
            }

            commands = Console.ReadLine()
            .Split()
            .ToList();
        }
    }
}

