using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonString = File.ReadAllText("../../../products.json");
            Product[] products = JsonSerializer.Deserialize<Product[]>(jsonString);

            Product maxPricePruduct = products[0];
            foreach (Product product in products)
            {

                if (product.Price > maxPricePruduct.Price)
                {
                    maxPricePruduct = product;
                }
            }
            Console.WriteLine($"Самы дооргой продукт: {maxPricePruduct.Name}, его цена: {maxPricePruduct.Price}");
            Console.ReadKey();
        }
    }
}
