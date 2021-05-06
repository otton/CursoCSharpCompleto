using System;
using System.Collections.Generic;
using System.IO;

namespace Arquivos_Directory_DirectoryInfo
{
    class Program
    {
        // Directory, DirectoryInfo
        static void Main(string[] args)
        {
            string path = @"C:\Users\Otton\Documents\Arquivos_testes";

            try
            {
                // Listar subpastas a partir da pasta PATH
                IEnumerable<string> Folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Listando Subpastas");
                foreach (string folder in Folders)
                {
                    Console.WriteLine(folder);
                }

                //Listando arquivos da subpastas listadas
                IEnumerable<string> Files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("\nListando arquivos das subpastas");
                foreach (string file in Files)
                {
                    Console.WriteLine(file);
                }

                //Criando pasta
                Directory.CreateDirectory(path + @"\Nova_Pasta");



                // Listar as subpastas e seus arquivos
                DirectoryInfo directoryInfo = new DirectoryInfo(path);
                IEnumerable<FileSystemInfo> Infos = directoryInfo.EnumerateFileSystemInfos("*.*", SearchOption.AllDirectories);
                Console.WriteLine("\nListar as subpastas e seus arquivos");
                foreach (FileSystemInfo info in Infos)
                {
                    Console.WriteLine(info);
                }

                //Listando subpastas
                DirectoryInfo DI = new DirectoryInfo(path);
                IEnumerable<DirectoryInfo> S = DI.EnumerateDirectories("*.*", SearchOption.AllDirectories);
                Console.WriteLine("\nListagem das Subpastas");
                foreach (var item in S)
                {
                    Console.WriteLine(item);
                }

                //Listar somente os arquivos txt da pasta contida na variavel path
                DirectoryInfo Dir = new DirectoryInfo(path);
                var arq = Dir.GetFiles("*.txt");
                Console.WriteLine("\nListagem somente dos arquivos da subpasta");
                foreach (var text in arq)
                {
                    Console.WriteLine(text);
                }

                //Caminho da pasta contida na variável path
                var caminho = Dir.FullName.ToString();
                Console.WriteLine("\nCaminho da pasta: \n" + caminho);

                Console.WriteLine("Path.GetFullPath: " + Path.GetFullPath(path)); 

                //Imprimindo conteúdo na tela do arquivo texto1.txt
                string[] lines = File.ReadAllLines(path + @"\texto1.txt");
                Console.WriteLine("\nImprimindo conteúdo na tela do arquivo texto1.txt:");
                foreach (var item in lines)
                {
                    Console.WriteLine(item);
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
