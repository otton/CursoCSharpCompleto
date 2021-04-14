using System;
using System.Collections.Generic;
using System.Text;

namespace TratamentoExcecoes.Entities.ApplicationException
{
    class BalanceException : Exception
    {
        public BalanceException(string message):base(message)
        {
        }
    }
}
