﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_2
{
    class Overdraft_account : Account,BasicBankInterface
    {
        public int amount { get; set; }
        public int overdraftLimit { get; set; }
        public Overdraft_account(string AccName, string AccNo, int balance, int overdraftLimit) : base(AccName, AccNo, balance)
        {
            this.overdraftLimit = overdraftLimit;
        }

        public override void Deposit(int amount)
        {
            balance += amount;
        }

        public override void Withdraw(int amount)
        {
            if (amount < balance + overdraftLimit)
            {
                balance -= amount;
            }
        }
    }
}
