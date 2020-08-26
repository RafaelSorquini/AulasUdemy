using System;
using System.Collections.Generic;
using System.Text;

namespace CursoUdemy.Entidades
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {
        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit, double withdrawlimit)
            : base(number, holder, balance, withdrawlimit)
        {
            LoanLimit = loanLimit;
        }

        public void Loan (double amount)
        {
            if (amount <= LoanLimit)
            Balance += amount;
        }
    }
}
