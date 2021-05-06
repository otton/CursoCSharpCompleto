using Exercicio_Fixacao.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Exercicio_Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Employee> list = new List<Employee>();

            using (StreamReader streamReader = File.OpenText(path))
            {
                while (!streamReader.EndOfStream)
                {
                    string[] dados = streamReader.ReadLine().Split(',');
                    string name = dados[0];
                    string email = dados[1];
                    double salary = double.Parse(dados[2], CultureInfo.InvariantCulture);
                    list.Add(new Employee(name, email, salary));
                }
            }

            Console.Write("Enter salary: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var mails = list.Where(x => x.Salary > valor).OrderBy(x => x.Email).Select(x => x.Email);
            Console.WriteLine("Email of people whose salary is more than " + valor.ToString("F2", CultureInfo.InvariantCulture));

            foreach (string mail in mails)
            {
                Console.WriteLine(mail);
            }

            var somaSalario = list.Where(x => x.Name[0] == 'M').Sum(x => x.Salary);
            Console.WriteLine("Sum of salary of people whose name starts with 'M': "+ somaSalario.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
