using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Lab8_SWE4202
{
    internal class CurrentAccount:Account
    {
        /*public override string AccSuffix(int ID)
        {
            //this.getID;
            return AccNO=+"300";
        }*/
        public  override string getID()
        {
            return this.AccNO= Convert.ToString(ID++) + "300";
        }
        public void setCurrentAccountBalance(int money)
        {
             this.MinAmount = money;
            this.Balance = this.Balance+money;

        }
        public override void getBalance(int amount)
        {
            this.Balance = this.Balance + amount;
        }
        public CurrentAccount()
        {

        }
        public void setinfo(string name, string contact)
        {
            this.Name = name;
            this.Contact = contact;
        }
        public override void getNewBalance(int amount)
        {
            if (this.Balance - amount < 500)
            {
                MessageBox.Show("Transaction Denied: Insufficient Remaining Balance");
                return;
            }
            this.Balance= this.Balance - amount;

            MessageBox.Show("Transaction Done.");
        }
    }
}
