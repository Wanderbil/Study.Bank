using System;
using System.Collections.Generic;
using System.Linq;
using Bank.Entities.Exceptions;
using Bank.Entities;

namespace Bank.Entities
{
    internal class Account
    {

        public int NumberAcc { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }
        public Account(int numberAcc, string holder, double balance, double withdrowLimit)
        {
            NumberAcc = numberAcc;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrowLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainExceptions("The amount exceeds withdraw limit.");
            }

            if (amount > Balance)
            {
                throw new DomainExceptions("Not enough balance!");
            }

            Balance -= amount;
        }



    }
}
