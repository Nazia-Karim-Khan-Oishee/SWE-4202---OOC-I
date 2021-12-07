using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3_SWE4201
{
    internal class Book
    {
        private string bid;
        private string bname;
        private string bauthor;
        private int bquantity;
         public Book(string bid, string bname , string bauthor , int bquantity)
        {
            this.bid = bid;
            this.bname = bname;
            this.bauthor = bauthor;
            this.bquantity = bquantity;
        }
        public Book()
        {

        }
        public string getbid()
        {
            return this.bid;
        }
        public string getname()
        {
            return this.bname;
        }
        public string getbquantity()
        {
            return Convert.ToString(this.bquantity);
        }
        public string getbooklist()
        {
            return this.bid+'\t' +this.bname+ '\t' + this.bauthor+ '\t'+ Convert.ToString(this.bid);
        }
        public void decrement()
        {
            this.bquantity--;
        }
    }
}
