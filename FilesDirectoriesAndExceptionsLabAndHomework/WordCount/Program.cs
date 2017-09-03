using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
public class Program
{
    public static void Main()
    {
        var words = File.ReadAllLines("words.txt");

        var text = File.ReadAllText("text.txt")
            .Split(" ,-!?.".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(x => x.ToLower()).ToArray();

        var dict = new Dictionary<string, int>();

        for (int i = 0; i < text.Length; i++)
        {
            for (int j = 0; j < words.Length; j++)
            {
                var word = words[j];

                if (text[i] == word)
                {
                    if (!dict.ContainsKey(word))
                    {
                        dict[word] = 0;
                    }

                    dict[word]++;
                }
            }
        }

        foreach (var item in dict.OrderByDescending(x => x.Value))
        {
            Console.WriteLine("{0} -> {1}", item.Key, item.Value);
        }
    }
}

