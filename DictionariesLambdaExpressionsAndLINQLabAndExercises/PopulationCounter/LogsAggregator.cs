using System;
using System.Collections.Generic;
using System.Linq;
public class LogsAggregator
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var userIps = new SortedDictionary<string, List<string>>();
        var list = new List<string>();
        var durations = new SortedDictionary<string, int>();

        for (int i = 0; i < n; i++)
        {
            var line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var ipAddress = line[0];
            var name = line[1];
            var duration = int.Parse(line[2]);

            if (!userIps.ContainsKey(name))
            {
                userIps[name] = new List<string>();
                userIps[name].Add(ipAddress);
            }
            else
            {
                userIps[name].Add(ipAddress);
            }
            if (!durations.ContainsKey(name))
            {
                durations[name] = duration;
            }
            else
            {
                durations[name] += duration;
            }
        }

        foreach (var userIp in userIps)
        {
            var username = userIp.Key;
            var ip = userIp.Value.Distinct().OrderBy(x => x);

            foreach (var duration in durations)
            {
                Console.WriteLine("{0}: {1} [{2}]", username, duration.Value, string.Join(", ", ip));
                durations.Remove(duration.Key);
                break;
            }
        }
    }
}

