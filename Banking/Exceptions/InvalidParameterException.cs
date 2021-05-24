using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Exceptions // notice that the namespace is different since we are in a folder labled exceptions
{
    public class InvalidParameterException : Exception //generally want to make the class public, so added public
    {
        //When you make an exception, need to make 3 constructors
            public decimal Amount { get; set; }
        public InvalidParameterException(decimal Amount) : base()
        {
            this.Amount = Amount;
        }
        public InvalidParameterException() : base() //This is an example of a default constructor in the class
        {
        }
        public InvalidParameterException(string Message) : base(Message)
        {
        }
        public InvalidParameterException(string Message, Exception InnerException) : base(Message, InnerException)
        {
        }

    }
}
