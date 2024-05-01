using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.IO;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int quantityProduct = 5;
            Product[] products = new Product[quantityProduct];

            for (int i = 0; i < quantityProduct; i++)
            {
                Console.Write("Код товара: ");
                int code = Convert.ToInt32(Console.ReadLine());
                Console.Write("Название товара: ");
                string name = Console.ReadLine();
                Console.Write("Цена товара: ");
                int price = Convert.ToInt32(Console.ReadLine());
                products[i] = new Product(code, name, price);
            }
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };

            string jsonString = JsonSerializer.Serialize(products, options);
            if (File.Exists("../../../products.json"))
            {
                File.Delete("../../../products.json");
            }

            File.AppendAllText("../../../products.json", jsonString);

        }
    }
}
