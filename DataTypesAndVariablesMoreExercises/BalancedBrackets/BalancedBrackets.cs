using System;
using System.Collections.Generic;
class BalancedBrackets
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var brackets = new List<string>();

        for (int i = 1; i <= n; i++)
        {
            string text = Console.ReadLine();

            if (text == "(")
            {
                brackets.Add(text);
            }
            else if (text == ")")
            {
                brackets.Add(text);
            }
        }

        bool leftBrackets = false;
        bool rightBrackets = false;

        for (int i = 0; i < brackets.Count; i++)
        {
            if (i % 2 == 0 && brackets[i] == "(" && i != brackets.Count - 1)
            {
                leftBrackets = true;
            }
            else if (i % 2 == 0)
            {
                leftBrackets = false;
                break;
            }

            if (i % 2 != 0 && brackets[i] == ")")
            {
                rightBrackets = true;
            }
            else if (i % 2 != 0)
            {
                rightBrackets = false;
                break;
            }
        }

        if (leftBrackets && rightBrackets)
        {
            Console.WriteLine("BALANCED");
        }
        else
        {
            Console.WriteLine("UNBALANCED");
        }
    }
}

