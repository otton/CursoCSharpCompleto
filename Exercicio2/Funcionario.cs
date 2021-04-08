using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2
{
    class Funcionario
    {
        public string Nome;
        public double Salario;
        public double Media;

        public double MediaSalarial(double valor1, double valor2)
        {
            Media = (valor1 + valor2) / 2.0;
            return Media;
        }
    }
}
