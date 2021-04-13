using ExercicioFixacao.ClasseAbstrata;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioFix_ClassAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
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
                if (ch == 'i' || ch == 'I')
                {
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, annual, health));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int number = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, annual, number));
                }
            }
            Console.WriteLine();

            Console.WriteLine("TAXES PAID:");
            foreach (TaxPayer taxPayer in list)
            {

                Console.WriteLine(taxPayer.Name + ": $ " + taxPayer.Tax().ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.WriteLine();

            double sum = 0.0;
            foreach (TaxPayer taxPayer in list)
            {
                sum += taxPayer.Tax();
            }
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}