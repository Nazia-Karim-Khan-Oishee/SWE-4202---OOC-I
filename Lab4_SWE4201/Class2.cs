using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_SWE4201
{
    internal class StudyBooks: Book
    {
        public string ISBN;
       public string genre;


        public string getbookinfo()
        {
            return ID + '\t' + Title + '\t' + Author + '\t' + Publisher + '\t' + Convert.ToString(quantity) + '\t' +ISBN + '\t' + genre;

        }
    }
    
}
