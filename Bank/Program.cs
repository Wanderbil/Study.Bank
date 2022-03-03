using System;
using System.Collections.Generic;
using Bank.Entities;
using System.Globalization;
using Bank.Entities.Exceptions;


namespace Bank
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter Acc Data: ");
            
            Console.Write("Number Acc: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial Balance: ");
            double initialBalance = double.Parse(Console.ReadLine());
            Console.Write("Enter amount for withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine());

            Account account = new Account(number, holder, initialBalance, withdrawLimit);

            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                account.Withdraw(amount);
                Console.WriteLine("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }

            catch (DomainExceptions e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }


        }
    }
}
