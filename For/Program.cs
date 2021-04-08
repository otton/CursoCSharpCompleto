using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números inteiros você vai digitar? ");
            int n = int.Parse(Console.ReadLine());

            int soma = 0;

            for (int i = 1; i <= n; i++) // Quantidade de N repetições.
            {
                Console.Write("Valor #" + i + ": ");
                int n1 = int.Parse(Console.ReadLine()); // Variável que guardará os valores digitados.
                soma += n1; // Variável que somará todas as variáveis digitadas.
            }
            Console.WriteLine("Soma = " + soma); // Resultado da soma das variáveis digitadas.
            Console.ReadKey();
        }
    }
}
