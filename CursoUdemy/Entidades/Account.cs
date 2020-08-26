using System;
using System.Collections.Generic;
using System.Text;

namespace CursoUdemy.Entidades
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawlimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawlimit;
        }

        public void Withdraw (double amount, double limit, double withdrawlimit)
        {
            if(withdrawlimit > limit)
            {
                throw new DomainException(" The amount exceeds withdraw limit");
            }

            if(withdrawlimit > amount)
            {
                throw new DomainException(" Not enough balance");
            }

            Balance = amount - withdrawlimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
