using ExercicioFix_Arquivos.Entities;
using System;
using System.Globalization;
using System.IO;

namespace ExercicioFix_Arquivos
{
    class Program
    {
        private static NumberStyles cultureinfo;

        static void Main(string[] args)
        {
            Console.Write("Entre com o caminho do arquivo de origem: ");
            string sourcepath = Console.ReadLine();

            try
            {
                string[] lines = File.ReadAllLines(sourcepath); //realizar a leitura do arquivo

                string sourceFolderPath = Path.GetDirectoryName(sourcepath);
                string targetFolderPath = sourcepath + @"\out";
                string targetPath = targetFolderPath + @"\summary.csv";

                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        string[] campos = line.Split(", ");
                        string name = campos[0];
                        double preco = double.Parse(campos[1], CultureInfo.InvariantCulture);
                        int quantidade = int.Parse(campos[2]);

                        Product prod = new Product(name, preco, quantidade);
                        sw.WriteLine(prod.Nome+","+prod.ValorTotal().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro: ");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}