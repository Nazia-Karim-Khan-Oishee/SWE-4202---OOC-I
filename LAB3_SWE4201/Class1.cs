using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3_SWE4201
{
    internal class User
    {
        private string id;
        private string name;
        private string address;
       
        public List<Book> books = new List<Book>();
        public User(string id, string name, string address)
        {
            this.id = id;
            this.name = name;
            this.address = address; 
        }

        public void setlist(Book newbook)
        {
            books.Add(newbook);
        }
        public string getuid()
        {
            return this.id;
        }
    }
}
