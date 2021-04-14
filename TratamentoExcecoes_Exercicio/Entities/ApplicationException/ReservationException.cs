using System;
using System.Collections.Generic;
using System.Text;

namespace TratamentoExcecoes_Exercicio.Entities.ApplicationException
{
    class ReservationException : Exception
    {
        public ReservationException(string message) : base(message)
        {
        }
    }
}
