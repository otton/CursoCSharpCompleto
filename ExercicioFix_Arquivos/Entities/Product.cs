using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFix_Arquivos.Entities
{
    class Product
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public Product(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double ValorTotal()
        {
            return Preco * Quantidade;
        }
    }
}
