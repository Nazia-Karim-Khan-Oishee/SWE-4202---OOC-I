using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_SWE4201
{
    internal class ResearchArticle: Book
    {
        public string doi;
        public string date;
        public string cj;

        public string getarticleinfo()
        {
            return ID+'\t'+Title +'\t'+Author+'\t'+Publisher +'\t'+ Convert.ToString(quantity) +'\t'+doi+'\t'+date +'\t' + cj;

        }
    }
}
