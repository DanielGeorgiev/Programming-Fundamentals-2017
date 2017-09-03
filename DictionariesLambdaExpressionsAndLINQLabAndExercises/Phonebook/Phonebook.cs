using System;
using System.Collections.Generic;
using System.Linq;
public class Phonebook
{
    public static void Main()
    {
        var command = Console.ReadLine()
            .Split(' ')
            .ToList();

        var contacts = new SortedDictionary<string, string>();

        while (command[0] != "END")
        {
            if (command[0] == "A")
            {
                string contact = command[1];
                string phoneNumber = command[2];

                contacts[contact] = phoneNumber;
            }

            else if (command[0] == "S")
            {
                string contact = command[1];

                SearchContact(contact,contacts);
            }

            else if (command[0] == "ListAll")
            {
                ListAllContacts(contacts);
            }

            command = Console.ReadLine()
            .Split(' ')
            .ToList();   
        }
    }

    public static void ListAllContacts(SortedDictionary<string, string> contacts)
    {
        foreach (var item in contacts)
        {
            Console.WriteLine("{0} -> {1}", item.Key, item.Value);
        }
    }

    public static void SearchContact(string contact, SortedDictionary<string, string> contacts)
    {
        if (contacts.ContainsKey(contact))
        {
            Console.WriteLine("{0} -> {1}", contact, contacts[contact]);
        }
        else
        {
            Console.WriteLine("Contact {0} does not exist.", contact);
        }
    }
}

