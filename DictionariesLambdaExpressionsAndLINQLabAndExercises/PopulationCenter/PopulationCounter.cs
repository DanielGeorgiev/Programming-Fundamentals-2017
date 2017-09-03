using System;
using System.Collections.Generic;
using System.Linq;
public class PopulationCounter
{
    public static void Main()
    {
        var line = Console.ReadLine();

        var countryCityPop = new Dictionary<string, Dictionary<string, long>>();

        while (line != "report")
        {
            var tokens = line.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            var country = tokens[1];
            var city = tokens[0];
            var population = long.Parse(tokens[2]);

            if (!countryCityPop.ContainsKey(country))
            {
                countryCityPop.Add(country, new Dictionary<string, long>());
                countryCityPop[country].Add("total population", 0);
            }

            if (!countryCityPop[country].ContainsKey(city))
            {
                countryCityPop[country].Add(city, 0);
            }

            countryCityPop[country]["total population"] += population;
            countryCityPop[country][city] += population;

            line = Console.ReadLine();
        }

        foreach (var item in countryCityPop.OrderByDescending(x => x.Value.Sum(y => y.Value)))
        {
            Console.WriteLine("{0} (total population: {1})", item.Key, countryCityPop[item.Key]["total population"]);    

            foreach (var city in item.Value.OrderByDescending(x => x.Value))
            {
                if (city.Key != "total population")
                {
                    Console.WriteLine("=>{0}: {1}", city.Key, city.Value);
                }
            }
        }
    }
}
