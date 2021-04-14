using System;
using System.Collections.Generic;
using System.Text;
using TratamentoExcecoes.Entities.ApplicationException;

namespace TratamentoExcecoes.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdDrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdDrawLimit = withdDrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (Balance <= 0 || (amount < WithdDrawLimit && amount > Balance)) //Se não houver saldo na conta ou saldo menor que o valor de saque
            {
                throw new BalanceException(" Not enough balance");
            }
            if (amount > WithdDrawLimit || amount > Balance) //Se o valor do saque for superior ao limite de saque da conta
            {
                throw new BalanceException("The amount exceeds withdraw limit");
            }
            Balance -= amount;
        }
    }
}
