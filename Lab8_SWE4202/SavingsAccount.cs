using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_SWE4202
{
    internal class SavingsAccount:Account
    {
        public int TransactionLimit = 5;
        public int TransactionNumber;
        public int WithdrawCharge=15;
        public override string getID()
        {
            return this.AccNO = Convert.ToString(ID++) + "314";
        }
        public void setCurrentAccountBalance(int money)
        {
            this.MinAmount = money;
            this.Balance = this.Balance + money;

        }
        public override void getBalance(int amount)
        {
            this.Balance = this.Balance + amount;
        }
        public SavingsAccount()
        {
            this.TransactionNumber = 0;
        }
        public void setinfo(string name, string contact)
        {
            this.Name = name;
            this.Contact = contact;
        }
        public override void getNewBalance(int amount)
        {
            this.Balance = (this.Balance) - amount ;
        }
    }
}
