using Predicate.Entities;
using System;
using System.Collections.Generic;

namespace Predicate
{
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

            //products.RemoveAll(x => x.Price <= 100.0); //Utilizando expressão lambda
            
            products.RemoveAll(RemoveProduct); //Utilizando a função externa (delegate Predicate)
            foreach (var item in products)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        static bool RemoveProduct(Product p)
        {
            return p.Price <= 100.0;
        }
    }
}
