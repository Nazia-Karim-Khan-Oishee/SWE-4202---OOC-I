using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_SWE4202
{
    public class User
    {
        public string firstname, lastname, company, address, city,
            country, state, zip, phone1, phone2, email;

        public User()
            {
            }
        public string getinfo()
        {
            return (this.firstname + " " + this.lastname +" " + this.company +" " + this.address + " " +
                this.city +" " + this.country + " " +  this.phone1 +" "
                + this.phone2 + " " + this.email );
        }

    }
}
