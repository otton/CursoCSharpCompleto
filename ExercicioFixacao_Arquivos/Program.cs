using ExercicioFixacao_Arquivos.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace ExercicioFixacao_Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecord> set = new HashSet<LogRecord>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime date = DateTime.Parse(line[1]);
                        set.Add(new LogRecord { Username = name, Instant = date });
                    }
                    Console.WriteLine("Total user: " + set.Count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Um erro ocorreu: ");
                Console.WriteLine(e.Message);
            }

        }
    }
}
