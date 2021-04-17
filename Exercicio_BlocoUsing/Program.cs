using System;
using System.IO;

namespace Exercicio_BlocoUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            string arquivo = @"C:\Users\Otton\Documents\Arquivos_testes\texto1.txt";

            try
            {
                using (StreamReader streamReader = File.OpenText(arquivo))
                {
                    while (!streamReader.EndOfStream)
                    {
                        string line = streamReader.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro:");
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
