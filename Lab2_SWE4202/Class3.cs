using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_SWE4202
{
    
        internal class Administrator
        {
            public string AdmID;
            public string AdmName;
            public string AdmDesignation;
            public string AdmSalary;


            public string getAdminfo()
            {
                string AdmInfo = AdmID +"\t" +AdmName + "\t" + AdmDesignation + "\t" + AdmSalary;
                return AdmInfo;
            }
        }
    }

