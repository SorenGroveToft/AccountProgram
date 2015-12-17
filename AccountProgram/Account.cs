using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace AccountProgram
{
    class Account
    {
        private double balance;

        public Account (double _balance)
        {

            balance = _balance;
        }
        [ContractArgumentValidator]
        public void deposit(double amount)
        {
            if (amount < 0) throw new ArgumentOutOfRangeException("The deposit amount cannot be below zero.");
            Contract.EndContractBlock();
            balance += amount;
        }


        [ContractArgumentValidator]
        public void withdraw(double amount)
        {
            if (amount < 0) throw new ArgumentOutOfRangeException("The withdraw amount cannot be below zero.");
            if (amount > getBalance()) throw new ArgumentOutOfRangeException("The withdraw amount cannot exceed the balance.");
            Contract.EndContractBlock();
            balance -= amount;
        }
        public double getBalance()
        {
            return balance;
        }

        public void setBalance(double _balance)
        {
            balance = _balance;
        }
    }
}
