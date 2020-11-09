using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace account
{ 
    class ACCOUNT
    {
        private String accName;

        private String acid;

        private int balance;

        public ACCOUNT(String accName, String acid, int balance)
        {
            this.accName = accName;
            this.acid = acid;
            this.balance = balance;
        }

        public void Deposit(int amount)
        {
            this.balance = balance + amount;
            Console.WriteLine(balance);
        }

        public void Withdraw(int amount)
        {
            if (balance > amount)
            {
                this.balance = balance - amount;
                Console.WriteLine(balance);
            }

        }
    }
