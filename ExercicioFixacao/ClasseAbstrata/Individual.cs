using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixacao.ClasseAbstrata
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double annualIncome, double healthExpenditures) : base(name, annualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }
        double imposto = 0.0;
        public override double Tax()
        {

            if (AnnualIncome < 20000.0)
            {
                imposto = ((AnnualIncome + AnnualIncome * 0.25) - (HealthExpenditures + HealthExpenditures * 0.50));
            }
            else
            {
                imposto = ((AnnualIncome + AnnualIncome * 0.15) - (HealthExpenditures + HealthExpenditures * 0.50));
            }

            return imposto;
        }
    }
}
