using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_SWE4202
{
    internal class LoanAccount : Account
    {
        public override string getID()
        {
            return this.AccNO = Convert.ToString(ID++) + "400";
        }

        public void setCurrentAccountBalance(int money)
        {
            this.MinAmount = money;
            this.Balance = this.Balance + money;
            this.Balance = this.Balance * 1.09;

        }
        public override void getBalance(int amount)
        {
            if(this.Balance-amount < 0)
            {
                MessageBox.Show("You can not deposit more than due amount");
                return;
            }
            this.Balance = this.Balance - amount;
            if(this.Balance==0)
            {
                MessageBox.Show("Your loan has been repayed");
            }
            else
            {
                MessageBox.Show("Transaction done.Your remaining amount: " + Convert.ToString(this.Balance));
            }
            
        }
        public LoanAccount()
        {

        }
        public void setinfo(string name, string contact)
        {
            this.Name = name;
            this.Contact = contact;
        }
        public override void getNewBalance(int amount)
        {
            this.Balance = this.Balance - amount;
        }
    }
}

