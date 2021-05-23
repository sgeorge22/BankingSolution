using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{ // Composition example - Showing how to call on info from another class with out inhereting it
    class Savings2
    {
        private Account account = new Account();
        public decimal InterestRate { get; internal set; } = 0.01m;
        public decimal CalculateInterestByMonths(int NumberOfMonths)
        {
            return account.Balance * (InterestRate / 12.0m) * NumberOfMonths;

        }

        public void PayInterest(int NumberOfMonths)
        {
            var interest = CalculateInterestByMonths(NumberOfMonths);
            Deposit(interest);
        }

        public bool Deposit(decimal amount)
        {
            return account.Deposit(amount);
        }
        public bool Withdraw(decimal amount)
        {
            return account.Withdraw(amount);
        }
        public bool Transfer(decimal amount, Account toAccount)
        {
            return account.Transfer(amount, toAccount);
        }
        //Have to create the below constructor to allow this to run
        public Savings2()
        {
            account = new Account();
        }
        

    }
}
