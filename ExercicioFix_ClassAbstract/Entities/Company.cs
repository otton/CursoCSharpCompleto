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
                imposto = AnnualIncome * 0.16;
            }
            else
            {
                imposto = AnnualIncome * 0.14;
            }
            return imposto;
        }
    }
}
