using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFinal_IUTRPS
{
    public class Students
    {
        public string studentID;
        public string name;
        public double attendance;
        public double quiz1, quiz2, quiz3, quiz4, mid, final, viva;
        public double quizTotal;
        public double total;
        public double percentage;
        public string grade;
        public Students(string id, string name, double attendance, double quiz1, double quiz2, double quiz3, double quiz4,
            double mid, double final, double viva)
        {
            this.studentID = id;
            this.name = name;
            this.attendance = attendance;
            this.quiz1 = quiz1;
            this.quiz2 = quiz2;
            this.quiz3 = quiz3;
            this.quiz4 = quiz4;
            this.mid = mid;
            this.final = final;
            this.viva = viva;
        }
       // public List<int> quizes = new List<int>();
    }
}

