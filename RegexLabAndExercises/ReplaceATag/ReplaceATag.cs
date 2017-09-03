using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
public class ReplaceATag
{
    public static void Main()
    {
        var line = Console.ReadLine();
        var pattern = @"<a(.*href=(.|\n)*?(?=>))>((.|\n)*?(?=<))<\/a>";
        var text = new StringBuilder();

        while (line != "end")
        {
            var matches = Regex.Matches(line, pattern);

            if (Regex.IsMatch(line, pattern))
            {
                foreach (Match match in matches)
                {
                    var replacedTags = Regex.Replace(line, pattern, "[URL " + match.Groups[1] +"]" + match.Groups[3] + "[/URL]");
                    text.Append(replacedTags + "\n");
                }
            }
            else
            {
                text.Append(line + "\n");
            }

            line = Console.ReadLine();
        }

        Console.WriteLine(text);
    }
}

