using System;
using System.IO;

namespace Arquivos_BlocoUsing
{
    // Bloco Using
    class Program
    {
        static void Main(string[] args)
        {
            string arquivo = @"C:\Users\Otton\Documents\Arquivos_testes\texto1.txt";

            try
            {
                using (FileStream fileStream = new FileStream(arquivo, FileMode.Open))
                {
                    using (StreamReader streamReader = new StreamReader(fileStream))
                    {
                        while (!streamReader.EndOfStream)
                        {
                            string linha = streamReader.ReadLine();
                            Console.WriteLine(linha);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Um erro ocorreu:");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}