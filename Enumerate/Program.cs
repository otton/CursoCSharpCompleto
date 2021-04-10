using Enumerate.Entities;
using Enumerate.Entities.Enum;
using System;

namespace Enumerate
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Momento = DateTime.Now,
                Status = OrderStatus.PagamentoPendente
            };

            Console.WriteLine(order);

            //Converter o formato enumerado em string e imprimir na tela:

            string txt = OrderStatus.Processando.ToString(); //Para converter, basta adicionar ao final do enum o ToString().

            Console.WriteLine(txt + "..."); //Apresentar a conversão na tela.

            //*********************************************************************

            //Converter um string para enumerado

            OrderStatus os = Enum.Parse<OrderStatus>("Entregue");

            Console.WriteLine(os);



            Console.ReadKey();
        }
    }
}
