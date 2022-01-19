using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7_SWE4202
{
    public class Course
    {
        public string name;
        public string level;
        public int fee;
        public Course(string name,string level,int fees)
        {
            this.name = name;
            this.level = level;
            this.fee = fees;
        }

    }
}
