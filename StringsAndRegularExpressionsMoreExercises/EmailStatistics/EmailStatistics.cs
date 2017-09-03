using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class EmailStatistics
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var emails = new Dictionary<string, List<string>>();

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine();
            var email = new Regex(@"^(?<username>[A-Za-z]{5,})@(?<host>[a-z]{3,}(\.com|\.bg|\.org))$");

            if (email.IsMatch(input))
            {
                var match = email.Match(input);
                var username = match.Groups["username"].Value;
                var host = match.Groups["host"].Value;

                if (!emails.ContainsKey(host))
                {
                    emails[host] = new List<string>();
                }

                if (!emails[host].Contains(username))
                {
                    emails[host].Add(username);
                }
            }
        }

        emails = emails.OrderByDescending(e => e.Value.Count).ToDictionary(x => x.Key, y => y.Value);

        foreach (var email in emails)
        {
            if (email.Value.Count != 0)
            {
                Console.WriteLine(email.Key + ":");
                foreach (var e in email.Value)
                {
                    Console.WriteLine("### " + e);
                }
            }
        }
    }
}

