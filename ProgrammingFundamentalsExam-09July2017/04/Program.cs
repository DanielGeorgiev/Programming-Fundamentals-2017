using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
public class Program
{
    class PokemonInfo
    {
        public string EvolutionType { get; set; }

        public int EvolutionIndex { get; set; }
    }

    public static void Main()
    {
        var pokemon = Console.ReadLine();
        var dict = new Dictionary<string, List<PokemonInfo>>();

        while (pokemon != "wubbalubbadubdub")
        {
            var tokens = pokemon
                .Split(" ->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
            var pokemonName = tokens[0];

            if (tokens.Length != 1)
            {
                var evolutionType = tokens[1];
                var evolutionIndex = int.Parse(tokens[2]);

                var pokemonInfo = new PokemonInfo()
                {
                    EvolutionType = evolutionType,
                    EvolutionIndex = evolutionIndex
                };

                if (!dict.ContainsKey(pokemonName))
                {
                    dict[pokemonName] = new List<PokemonInfo>();
                }

                dict[pokemonName].Add(pokemonInfo);
            }
            else if (tokens.Length == 1)
            {
                if (dict.ContainsKey(pokemonName))
                {
                    Print(dict, pokemonName);
                }
            }

            pokemon = Console.ReadLine();
        }

        foreach (var pok in dict)
        {
            Console.WriteLine("# {0}", pok.Key);

            var pokemonInfo = pok.Value.OrderByDescending(x => x.EvolutionIndex).ToList();

            foreach (var item in pokemonInfo)
            {
                Console.WriteLine(item.EvolutionType + " <-> " + item.EvolutionIndex);
            }
        }
    }

    static void Print(Dictionary<string, List<PokemonInfo>> dict, string pokemonName)
    {
            Console.WriteLine("# {0}", pokemonName);
            foreach (var pokemonInfo in dict[pokemonName])
            {
                Console.WriteLine("{0} <-> {1}", pokemonInfo.EvolutionType, pokemonInfo.EvolutionIndex);
            }
    }
}

