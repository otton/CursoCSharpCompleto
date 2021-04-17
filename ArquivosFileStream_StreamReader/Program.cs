using System;
using System.IO;

namespace ArquivosFileStream_StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string arquivo = @"C:\Users\Otton\Documents\Arquivos_testes\texto1.txt";
            StreamReader streamReader = null;

            try
            {
                streamReader = File.OpenText(arquivo);
                while (!streamReader.EndOfStream) //Enquanto nao ler todo o arquivo, continue lendo linha a linha.
                {
                    string linha = streamReader.ReadLine(); //Leia a linha
                    Console.WriteLine(linha); // Apresente na tela
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro:");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (streamReader != null) 
                    streamReader.Close();
                {

                }
            }
            Console.ReadKey();
        }
    }
}
