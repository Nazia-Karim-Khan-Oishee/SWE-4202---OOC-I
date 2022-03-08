using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_SWE4202
{
    
        internal class Teacher
        {
            public string TeacherID;
            public string TeacherName;
            public string TeacherDesignation;
            public string TeacherDept;
            public string TeacherSalary;
            

            public string getTeacherinfo()
            {
                string TeacherInfo = TeacherID+"\t" + TeacherName + "\t" +TeacherDept + "\t" + TeacherDesignation+ "\t" + TeacherSalary;
                return TeacherInfo;
            }
        }
    }

