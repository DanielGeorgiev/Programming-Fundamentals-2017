using System;
using System.Collections.Generic;
using System.Linq;
public class UserLogs
{
    public static void Main()
    {
        var line = Console.ReadLine();

        var usernames = new SortedDictionary<string, Dictionary<string, int>>();

        while (line != "end")
        {
            var tokens = line.Split(new char[] { ' ' });
            var splittedIpAddress = tokens[0].Split("IP=".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var ipAddress = splittedIpAddress[0];
            var splittedUser = tokens[2].Split("=".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Skip(1).ToArray();
            var user = splittedUser[0];

            if (!usernames.ContainsKey(user))
            {
                usernames.Add(user, new Dictionary<string, int>());

                if (!(usernames[user].ContainsKey(ipAddress)))
                {
                    usernames[user][ipAddress] = 1;
                }
                else
                {
                    usernames[user][ipAddress]++;
                }
            }
            else
            {
                if (!(usernames[user].ContainsKey(ipAddress)))
                {
                    usernames[user][ipAddress] = 1;
                }
                else
                {
                    usernames[user][ipAddress]++;
                }
            }

            line = Console.ReadLine();
        }

        usernames.OrderBy(x => x);

        foreach (var name in usernames)
        {
            var username = name.Key;

            Console.WriteLine("{0}:", username);

            int count = name.Value.Count;

            foreach (var item in name.Value)
            {
                if (count != 1)
                {
                    Console.Write("{0} => {1}, ", item.Key, item.Value);
                }
                else
                {
                    Console.WriteLine("{0} => {1}.", item.Key, item.Value);
                }
                count--;
            }
        }
    }
}

