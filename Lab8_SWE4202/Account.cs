using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_SWE4202
{
    internal abstract class Account
    {
        public string AccNO;
        public string Name;
        public string Contact;
        public int MinBalance;
        public int MinAmount;
        //public int TransactionLimit;
        public int MaxTransactionAmount;
        public double Balance=0;
       public static int ID=1;
        //public abstract void getID();

        /*public abstract string AccSuffix();
        {
            ;
        }*/
        public abstract string getID();
        public abstract void getBalance(int amount);
        public abstract void getNewBalance(int amount);
    }
}
