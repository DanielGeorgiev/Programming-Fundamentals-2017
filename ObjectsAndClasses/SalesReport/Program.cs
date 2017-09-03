using System;
using System.Collections.Generic;
using System.Linq;
class SalesReport
{
    public class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
    }

    public class SalesByTown
    {
        public string Town { get; set; }
        public decimal Turnover { get; set; }

        public static void Summary(List<Sale> sales)
        {
            var dict = new Dictionary<string, decimal>();

            for (int i = 0; i < sales.Count; i++)
            {
                var sale = sales[i];

                if (!dict.ContainsKey(sale.Town))
                {
                    dict.Add(sale.Town, 0.0m);
                }

                dict[sale.Town] += sale.Price * sale.Quantity;
            }

            foreach (var item in dict.OrderBy(x => x.Key))
            {
                Console.WriteLine("{0} -> {1:f2}",item.Key, item.Value);
            }
        }
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var salesList = new List<Sale>();

        for (int i = 1; i <= n; i++)
        {
            ReadSale(salesList);  
        }

        SalesByTown.Summary(salesList);
    }

    public static void ReadSale(List<Sale> salesList)
    {
        var input = Console.ReadLine();
        var tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
        var sale = new Sale
        {
            Town = tokens[0],
            Product = tokens[1],
            Price = decimal.Parse(tokens[2]),
            Quantity = decimal.Parse(tokens[3])
        };

        salesList.Add(sale);
    }
}

