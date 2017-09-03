using System;
using System.Collections.Generic;
using System.Linq;
public class OrderByAge
{
    class Person
    {
        public string Name { get; set; }

        public string ID { get; set; }

        public uint Age { get; set; }
    }

    public static void Main()
    {
        var input = Console.ReadLine();

        var peopleList = new List<Person>();

        while (input != "End")
        {
            var tokens = input
                .Split().ToArray();
            var name = tokens[0];
            var id = tokens[1];
            var age = uint.Parse(tokens[2]);

            var person = new Person()
            {
                Name = name,
                ID = id,
                Age = age
            };

            peopleList.Add(person);

            input = Console.ReadLine();
        }

        peopleList = peopleList.OrderBy(person => person.Age).ToList();

        foreach (var person in peopleList)
        {
            Console.WriteLine("{0} with ID: {1} is {2} years old.", person.Name, person.ID, person.Age);
        }
    }
}

