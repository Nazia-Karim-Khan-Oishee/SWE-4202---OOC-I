using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7_SWE4202
{
    public class Participant
    {
        public string Name;
        public string RegistrationNo;
        public string ContactNo;
        public string Email;
        public string Level;
        public Course courses;
        public string date;
        public int fee;
        public List<Course>listofcourses=new List<Course>();
        //public List<Participant> participantslist;


        /*public Participant(string Name, string Regno, string Contact , string email,
            string level)
        {
            this.Name = Name;
            this.RegistrationNo = Regno;    
            this.ContactNo = Contact;
            this.Email = email;
            this.Level = level;
        }*/
        public virtual void setfee(int fee)
        {
            this.fee = this.fee + fee;
        }
    }
}
