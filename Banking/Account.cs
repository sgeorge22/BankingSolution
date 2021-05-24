using Banking.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    class Account
    {

        //Below is the properties
        public string AccountNumber { get; private set; }
        public decimal Balance { get; private set; }
        public string RoutingNumber { get; private set; }
        public string Description { get; set; }

        //Below is the methods
        public virtual bool Deposit(decimal amount)
        { // now we are in the deposit method 
            if (amount <= 0) // boolean to check first that the return wont produce a false
            {
                throw new InvalidParameterException(amount);
                
            }
            Balance = Balance + amount; // Balance + amount will return the value to the left side of the =
            return true;

        }
        public virtual bool Withdraw(decimal amount)
        {// we are now in the withdraw method
            if (amount <= 0) // boolean to check first that the return wont produce a false
            {
                throw new InvalidParameterException(amount);
            }
            if (amount > Balance)
            {
                throw new InsufficientFundsException(amount, Balance);
                
                
            }
            
            Balance = Balance - amount;
            return true;
        } // now tab to Program and create and instance of the above methods 

        //now create a method to transfer between accounts
        public bool Transfer(decimal amount, Account toAccount)//create a variable for the account you are going to transfer into
        {
            var success = Withdraw(amount); //here we created a variable for the Withdraw(amount) so that we could use it in a simplified bool expression
                if(success == true)//bool expression that is using our variable success to check if the statement is true
                {
                toAccount.Deposit(amount);//having this in the statement would allow for the bool to only move to this if the bool is true
                return true;
                }
            return false;
            
           

        }
       
    }
}
