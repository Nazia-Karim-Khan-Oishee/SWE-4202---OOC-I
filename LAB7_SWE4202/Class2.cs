using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7_SWE4202
{
    internal class Student:Participant
    {
        //public int fee=0;
        public Student(string name, string Regno, string Contact, string email,
            string level)
        {
            Name = name;
            RegistrationNo = Regno;
            //Enroll.Items.Add
            ContactNo = Contact;
            Email = email;
            Level = level;
        }
        public override void setfee(int fee)
        {
            this.fee = this.fee + fee;
        }
    }
}
