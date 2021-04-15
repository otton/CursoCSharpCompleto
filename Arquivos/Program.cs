using System;
using System.IO;

namespace Arquivos
{
    class Program
    {
        // File, FileInfo, IOException
        static void Main(string[] args)
        {
            string Origem = @"C:\Users\Otton\Documents\Arquivos_testes\texto1.txt";
            string Destino = @"C:\Users\Otton\Documents\Arquivos_testes\texto2.txt";

            try
            {
                FileInfo fi = new FileInfo(Origem);
                fi.CopyTo(Destino);
                string[] lines = File.ReadAllLines(Origem);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Ocorreu um erro:");
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
