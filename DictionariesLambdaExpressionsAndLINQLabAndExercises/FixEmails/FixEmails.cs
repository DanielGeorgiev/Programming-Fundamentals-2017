using System;
using System.Collections.Generic;
using System.Linq;
public class FixEmails
{
    public static void Main()
    {
        string name = Console.ReadLine();

        var nameAndEmail = new Dictionary<string, string>();

        while (name != "stop")
        {
            string email = Console.ReadLine();

            var splitEmail = email.Split('.').ToArray();
            var domain = (splitEmail[1] != "us" && splitEmail[1] != "uk");

            if (domain)
            {
                nameAndEmail.Add(name, email);
            }

            name = Console.ReadLine();
        }

        foreach (var item in nameAndEmail)
        {
            Console.WriteLine("{0} -> {1}", item.Key, item.Value);
        }
    }
}
