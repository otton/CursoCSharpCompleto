using System;
using System.IO;

namespace ExerciciosDeArquivos
{
    class Program
    {
        //FileStream, StreamReader
        static void Main(string[] args)
        {
            string path = @"C:\Users\Otton\Documents\Arquivos_testes\texto1.txt";
            //FileStream fileStream = null;
            StreamReader streamReader = null;

            try
            {
                //fileStream = new FileStream(path, FileMode.Open);
                //streamReader = new StreamReader(fileStream);

                streamReader = File.OpenText(path); //O OpenText implicitamente instancia o FileStream e o StreamReader em cima dele automaticamente
                while (!streamReader.EndOfStream) //Enquanto não ler todo o arquivo, ler uma linha e mostrar na tela
                {
                    string line = streamReader.ReadLine();
                    Console.WriteLine(line);
                }
                
                //string line = streamReader.ReadLine(); //Ler somente uma linha do arquivo
                //Console.WriteLine(line); //Mostra na tela.
            }
            catch (IOException e)
            {
                Console.WriteLine("Um erro ocorreu:");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (streamReader != null)
                    streamReader.Close();

                //if (fileStream != null)
                //    fileStream.Close();
            }
        }
    }
}
