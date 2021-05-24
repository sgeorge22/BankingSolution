using System;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            var sv1 = new Savings2();
            sv1.Deposit(2000);
            var cd10 = new CertOfDeposit2(5000, 60);

            var accounts = new IBank[]{sv1, cd10};
            foreach(var acct in accounts)
            {
                Console.WriteLine($"Account balance is {acct.GetBalance()}.");
            }


            //var sav1 = new Savings();
            //sav1.Deposit(1000);
            //sav1.InterestRate = 0.12m;
            //sav1.PayInterest(3);

            //var cd2 = new CertOfDeposit2(Amount: 1000, int 24);
            //cd2.Deposit(1);
            //cd2.Withdraw(1);
            //cd2.WithdrawDate = DateTime.Now 



            //creating an istance of our methods on the Account tab
            //var acc1 = new Account();
            //acc1.Deposit(500);
            //acc1.Withdraw(200);
            //acc1.Withdraw(600);
            //acc1.Deposit(-400);
            //Console.WriteLine($"Balance is {acc1.Balance}.");


            //var acc2 = new Account();
            //acc1.Transfer(1000, acc2);
            //Console.WriteLine($"Balance is {acc2.Balance}.");




            var CD1 = new CertificateOfDeposit(24);

            CD1.Deposit(5000);
            CD1.Withdraw(5000);

        }





    }
}
