using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    class Savings : Account
    {
        public decimal InterestRate { get; internal set; } = 0.01m; 
        public decimal CalculateInterestByMonths(int NumberOfMonths)
        {
            return Balance * (InterestRate / 12.0m) * NumberOfMonths;
            
        }

        public void PayInterest(int NumberOfMonths)
        {
            var interest = CalculateInterestByMonths(NumberOfMonths);
            Deposit(interest);
        }
         

    }
}
