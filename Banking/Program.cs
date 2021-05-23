using System;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            //var sav1 = new Savings();
            //sav1.Deposit(1000);
            //sav1.InterestRate = 0.12m;
            //sav1.PayInterest(3);

            



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
