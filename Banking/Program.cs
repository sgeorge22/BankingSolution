using System;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {//creating an istance of our methods on the Account tab
            var acc1 = new Account();
            acc1.Deposit(500);
            acc1.Withdraw(200);
            acc1.Withdraw(600);
            acc1.Deposit(-400);
            Console.WriteLine($"Balance is {acc1.Balance}.");


            var acc2 = new Account();
            acc1.Transfer(1000, acc2);
            Console.WriteLine($"Balance is {acc2.Balance}.");
        }


    }
}
