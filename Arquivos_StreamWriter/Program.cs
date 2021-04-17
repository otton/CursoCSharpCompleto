using System;
using System.IO;

namespace Arquivos_StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string Origem = @"C:\Users\Otton\Documents\Arquivos_testes\texto1.txt";
            string Destino = @"C:\Users\Otton\Documents\Arquivos_testes\texto2.txt";

            try
            {
                // Leitura do arquivo de origem
                string[] linhas = File.ReadAllLines(Origem);

                using (StreamWriter sw = File.AppendText(Destino))
                {
                    foreach (string linha in linhas)
                    {
                        sw.WriteLine(linha.ToUpper()); //Conversão da string para maiúsculo
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro");
                Console.WriteLine(e.Message);
            }
        }
    }
}
