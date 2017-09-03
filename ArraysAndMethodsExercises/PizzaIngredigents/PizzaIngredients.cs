using System;
using System.Linq;
using System.Collections.Generic;
public class PizzaIngredients
{
    public static void Main()
    {
        var ingredients = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        var ingredientLength = int.Parse(Console.ReadLine());

        var addedIngredients = new List<string>();

        for (int i = 0; i < ingredients.Length; i++)
        {
            if (addedIngredients.Count == 10)
            {
                break;
            }
            else if (ingredients[i].Length == ingredientLength)
            {
                Console.WriteLine("Adding {0}.", ingredients[i]);
                addedIngredients.Add(ingredients[i]);
            }
        }

        Console.WriteLine("Made pizza with total of {0} ingredients.", addedIngredients.Count);
        Console.WriteLine("The ingredients are: {0}.", string.Join(", ", addedIngredients));
    }
}

