using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_SWE4202
{
    public class NegativeCase:Exception
    {
        public NegativeCase(string message):base(message)
        {

        }

    }
}
