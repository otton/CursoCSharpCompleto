using Delegate_Func.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegate_Func
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

            //Func<Product, string> func = NameUpper;
            //Func<Product, string> func = p => p.Name.ToUpper();

            //List<string> result = products.Select(func).ToList();

            List<string> result = products.Select(p => p.Name.ToUpper()).ToList();

            foreach ( string s in result)
            {
                Console.WriteLine(s);
            }

            
            Console.ReadKey();
        }

        //static string NameUpper(Product p)
        //{
        //    return p.Name.ToUpper();
        //}

    }
}
