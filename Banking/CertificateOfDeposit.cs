using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    class CertificateOfDeposit : Account
    {
        public DateTime DepositDate { get; private set; }
        public DateTime WithdrawDate { get; private set; }
        public decimal InterestRate { get; private set; }
        public int CdDuration { get; private set; }

        public override bool Deposit(decimal amount)
        {
            if (Balance > 0)
            {
                Console.WriteLine("Cannot make additional deposit.");
                return false;
            }
            DepositDate = DateTime.Now;
            WithdrawDate = DepositDate.AddMonths(CdDuration);
            return base.Deposit(amount);
        }


        public override bool Withdraw(decimal amount)
        {
            if(DateTime.Now < WithdrawDate)
            {
                Console.WriteLine($"Balance withdrawal not avalible until {WithdrawDate}.");
                return false;
            }
            var interest = Balance * (InterestRate / 12.0m) * CdDuration;

            base.Deposit(interest);

            return base.Withdraw(Balance);
        }
        public CertificateOfDeposit(int CdDuration)
        {
            this.CdDuration = CdDuration;
            switch (this.CdDuration)
            {
                case 12:
                    InterestRate = 0.01m;
                    break;
                case 24:
                    InterestRate = 0.02m;
                    break;
                case 36:
                    InterestRate = 0.03m;
                    break;
                case 48:
                    InterestRate = 0.04m;
                    break;
                case 60:
                    InterestRate = 0.05m;
                    break;
            }

        }  
       








    }
}
