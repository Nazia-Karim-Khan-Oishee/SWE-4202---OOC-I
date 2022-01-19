using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7_SWE4202
{
    internal class Professional:Participant
    {
       // public int Fee;
        public override void setfee(int fee)
        {
            this.fee = this.fee + fee +fee*(20/100);
        }
        public  Professional(string name, string Regno, string Contact, string email,
            string level)
        {
            Name = name;
            RegistrationNo = Regno;
            ContactNo = Contact;
            Email = email;
            Level = level;
        }
    }
}
