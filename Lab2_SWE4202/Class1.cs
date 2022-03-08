using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_SWE4202
{
    internal class Student
    {
         
           // public string StudentName;
            //public string StudentID;
           // public string StudentDept;
           // public string StudentSemester;

            public string getstudentinfo()
            {
                string StInfo = StudentName + "\t" + StudentID + "\t" + StudentDept +"\t" + StudentSemester;
                return StInfo;
            }

        private string StudentName;
        private string StudentID;
        private string StudentDept;
        private string StudentSemester;
        public void setstudentid(string studentid)
        { 
            this.StudentID = studentid;
        }
        public string getstudentid(string studentid)
        {
            return this.StudentID;  
        }
        public void setstudentname(string studentname)
        {
            this.StudentName = studentname;
        }
        public string getstudentname(string studentname)
        {
            return this.StudentName;
        }
        public void setstudentdept(string studentdept)
        {
            this.StudentDept = studentdept;
        }
        public string getstudentdept(string studentdept)
        {
            return this.StudentDept;
        }
        public void setstudentsem(string studentsemester)
        { 
            this.StudentSemester= studentsemester;
        }
        public string getstudentsem(string studentsemester)
        {
            return this.StudentSemester;
        }
    }

}


