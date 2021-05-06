using Action.Entities;
using System;
using System.Collections.Generic;

namespace Action
{
    //Aumentar o preço dos produtos em 10%
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product("Televisão", 1900.0));
            products.Add(new Product("Microondas", 50.0));
            products.Add(new Product("Computador", 785.0));
            products.Add(new Product("Video-game", 90.0));
            products.Add(new Product("NetBook Usado", 101.0));

            //products.ForEach(p => p.Price += p.Price * 0.1);

            //products.ForEach(UpdatePrice);

            Action<Product> action = UpdatePrice;
            products.ForEach(action);

            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }
            Console.ReadKey();
        }

        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}
