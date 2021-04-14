﻿using System;
using System.Globalization;
using TratamentoExcecoes.Entities;
using TratamentoExcecoes.Entities.ApplicationException;

namespace TratamentoExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withDrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Account account = new Account(number, holder, balance, withDrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Withdraw(amount);
                Console.WriteLine("New Balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (BalanceException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }

            Console.ReadKey();
        }
    }
}
