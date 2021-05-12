using System;
using System.Collections.Generic;
using System.IO;
using Conjunto_ExercicioExemplo.Entities;

namespace Conjunto_ExercicioExemplo
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<RegistroDeLog> set = new HashSet<RegistroDeLog>();

            Console.Write("Entre com o caminho do arquivo: ");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader streamReader = File.OpenText(path))
                {
                    while (!streamReader.EndOfStream)
                    {
                        string[] linha = streamReader.ReadLine().Split(' ');
                        string usuario = linha[0];
                        DateTime instante = DateTime.Parse(linha[1]);
                        set.Add(new RegistroDeLog { Usuario = usuario, Instante = instante });
                    }
                    Console.WriteLine("Total de usuários: " + set.Count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
