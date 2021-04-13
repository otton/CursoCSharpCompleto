using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixacao.ClasseAbstrata
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double annualIncome, int numberOfEmployees) : base(name, annualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        double imposto = 0.0;
        public override double Tax()
        {
            if (NumberOfEmployees <= 10)
            {
                imposto = NumberOfEmployees + NumberOfEmployees * 0.16;
            }
            else
            {
                imposto = NumberOfEmployees + NumberOfEmployees * 0.14;
            }
            return imposto;
        }
    }
}
