using System;
using System.Collections.Generic;
using System.Linq;
public class HandsOfCards
{
    public static void Main()
    {
        var line = Console.ReadLine();
        var namesCards = new Dictionary<string, List<int>>();

        while (line != "JOKER")
        {
            var tokens = line.Split(':').ToArray();

            var name = tokens[0];
            var cards = tokens[1]
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(CalculateCardValue).ToArray();

            if (!namesCards.ContainsKey(name))
            {
                namesCards[name] = new List<int>();
            }

            namesCards[name].AddRange(cards);

            line = Console.ReadLine();
        }

        foreach (var nameCard in namesCards)
        {
            var name = nameCard.Key;
            var cards = nameCard.Value;

            var totalCards = cards.Distinct().Sum();

            Console.WriteLine("{0}: {1}", name, totalCards);
        }
    }

    public static int CalculateCardValue(string card)
    {
        var cardPowers = new Dictionary<string, int>();

        for (int i = 2; i <= 10; i++)
        {
            cardPowers[i.ToString()] = i;
        }

        cardPowers["J"] = 11;
        cardPowers["Q"] = 12;
        cardPowers["K"] = 13;
        cardPowers["A"] = 14;

        var cardTypes = new Dictionary<string, int>();
        cardPowers["S"] = 4;
        cardPowers["H"] = 3;
        cardPowers["D"] = 2;
        cardPowers["C"] = 1;

        var power = card.Substring(0, card.Length - 1);
        var type = card.Substring(card.Length - 1);

        return cardPowers[power] * cardPowers[type];
    }
}

