using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_2
{
    class Saving_account : Account , BasicBankInterface
    {
        public int amount { get; set; }
        public Saving_account(string AccName, string AccNo, int balance) : base(AccName, AccNo, balance)
        {
        }

        public override void Deposit(int amount)
        {
            balance += amount;
        }

        public override void Withdraw(int amount)
        {
            if (amount < balance - balance * 20 / 100)
            {
                balance -= amount;
            }
        }


    }
}
