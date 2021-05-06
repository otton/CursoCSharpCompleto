using Delegates_Exemplo1.Services;
using System;

namespace Delegates_Exemplo1
{
    class Program
    {
        delegate void Calculadora(double n1, double n2);
        static void Main(string[] args)
        {
            double a = 20, b = 45;

            Calculadora calc = CalculationService.ShowMax;
            calc += CalculationService.ShowSum;
            //calc(a, b);
            calc.Invoke(a, b);
        }
    }
}
