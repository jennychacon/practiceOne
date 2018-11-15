using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Products>();
            //prueba
            ProductFixPrice objProductFixPrice = new ProductFixPrice(1, "leche", 2300M, .17f);
            ProductFixPrice objProductFixPrice2 = new ProductFixPrice(2, "pan", 1200M, .17f);
            ProductVariablePrice objProductVariablePrice = new ProductVariablePrice(3, "Mango tomy", "kilo", 5200M, 1.543f, 1f);
            ProductVariablePrice objProductVariablePrice2 = new ProductVariablePrice(3, "cable utp-6", "metros", 8000M, 50.5f, 19f);
            products.Add(objProductFixPrice);
            products.Add(objProductFixPrice2);
            products.Add(objProductVariablePrice);
            products.Add(objProductVariablePrice2);

            decimal value = 0;
            decimal tax = 0;

            foreach (var product in products)
            {
                Console.WriteLine(product.ToString());
                value += product.GetPrice();
                tax += product.GetTax();
            }
            Console.WriteLine("===================================");
            Console.WriteLine($"TOTAL TO PAY.........:{value,12:C2}");
            Console.WriteLine($"TOTAL TAX............:{tax,12:C2}");
            Console.WriteLine("press enter to finish");
            Console.ReadKey();
        }
    }
}
