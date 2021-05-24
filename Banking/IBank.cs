using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    interface IBank
    {
        decimal GetBalance();
        string GetAccountNumber();
        
    }
}
