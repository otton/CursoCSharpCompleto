using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ListasExercicio
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void IncreaseSalary(double percentage)
        {
            Salario = Salario + Salario*(percentage/100.0);
        }

        public override string ToString()
        {
            return Id + ", " + Nome + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
