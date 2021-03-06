using ExercicioFixacao.ClasseAbstrata;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.WriteLine("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double annual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == i || ch == 'I')
                {
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, annual, health));
                }
                else
                {
                    Console.WriteLine("Number of employees: ");
                    int number = int.Parse(Console.ReadLine());
                    list.Add(new Company(name,annual,number));
                }
            }
            Console.WriteLine();
            foreach (TaxPayer taxPayer in list)
            {
                Console.WriteLine("TAXES PAID:");
                Console.WriteLine("Name: $ "+ taxPayer.Tax().ToString("F2", CultureInfo.InvariantCulture));
            }

            double sum = 0.0;
            foreach(TaxPayer taxPayer in list)
            {
                sum += taxPayer.Tax();
                Console.WriteLine("TOTAL TAXES: $ "+ sum);
            }

            Console.ReadKey();
        }
    }
}