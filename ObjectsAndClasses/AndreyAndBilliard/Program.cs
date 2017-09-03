using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    class Client
    {
        public string Name { get; set; }

        public Dictionary<string, int> Products { get; set; }

        public decimal Bill { get; set; }
    }

    static void Main()
    {
        var entitiesAmount = int.Parse(Console.ReadLine());

        var entities = new Dictionary<string, decimal>();

        for (int i = 0; i < entitiesAmount; i++)
        {
            var entity = Console.ReadLine()
                .Split('-')
                .ToArray();

            var product = entity[0];
            var price = decimal.Parse(entity[1]);

            if (!entities.ContainsKey(product))
            {
                entities.Add(product, 0);
            }

            entities[product] = price;
        }

        var sale = Console.ReadLine();

        var clientsList = new List<Client>();

        while (sale != "end of clients")
        {
            var tokens = sale
                .Split('-', ',').ToArray();
            var clientName = tokens[0];
            var product = tokens[1];
            var quantity = int.Parse(tokens[2]);

            var productQuantity = new Dictionary<string, int>();

            if (entities.ContainsKey(product))
            {
                productQuantity[product] = 0;
                productQuantity[product] += quantity;

                var client = new Client()
                {
                    Name = clientName,
                    Products = productQuantity,
                    Bill = entities[product] * quantity
                };

                clientsList.Add(client);
            }

            sale = Console.ReadLine();
        }

        clientsList = clientsList.OrderBy(client => client.Name).ToList();

        var totalBill = 0.0m;

        foreach (var client in clientsList)
        {
            Console.WriteLine("{0}", client.Name);

            foreach (var item in client.Products)
            {
                Console.WriteLine("-- {0} - {1}", item.Key, item.Value);
            }

            Console.WriteLine("Bill: {0:f2}", client.Bill);
            totalBill += client.Bill;
        }

        Console.WriteLine("Total bill: {0:f2}", totalBill);
    }
}
