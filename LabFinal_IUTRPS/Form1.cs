using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LabFinal_IUTRPS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            using (var reader = new StreamReader(@"E:\SWE4201MarkSheet.csv"))
            {

                while (!reader.EndOfStream)
                {

                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    double attendance;
                    double quiz1;
                    double quiz2;
                    double quiz3;
                    double quiz4;
                    double mid;
                    double final;
                    double viva;
                    if (values[2] == "")
                    {
                        attendance = 0;

                    }
                    else
                    {
                        attendance = Convert.ToDouble(values[2]);
                    }
                    if (values[3] == "")
                    {
                        quiz1 = 0;

                    }
                    else
                    {
                        quiz1 = Convert.ToDouble(values[3]);
                    }
                    if (values[4] == "")
                    {
                        quiz2 = 0;

                    }
                    else
                    {
                        quiz2 = Convert.ToDouble(values[4]);
                    }
                    if (values[5] == "")
                    {
                        quiz3 = 0;

                    }
                    else
                    {
                        quiz3 = Convert.ToDouble(values[5]);
                    }
                    if (values[6] == "")
                    {
                        quiz4 = 0;

                    }
                    else
                    {
                        quiz4 = Convert.ToDouble(values[6]);
                    }
                    if (values[7] == "")
                    {
                        mid = 0;

                    }
                    else
                    {
                        mid = Convert.ToDouble(values[7]);
                    }
                    if (values[8] == "")
                    {
                        final = 0;

                    }
                    else
                    {
                        final = Convert.ToDouble(values[8]);
                    }
                    if (values[9] == "")
                    {
                        viva = 0;

                    }
                    else
                    {
                        viva = Convert.ToDouble(values[9]);
                    }

                    Students astudent = new Students(values[0], values[1], attendance, quiz1, quiz2, quiz3, quiz4, mid, final, viva);

                    List<double> quizes = new List<double>();

                    quizes.Add(astudent.quiz1);
                    quizes.Add(astudent.quiz2);
                    quizes.Add(astudent.quiz3);
                    quizes.Add(astudent.quiz4);
                    quizes.Sort();

                    astudent.total = attendance + quizes[3] + quizes[2] + quizes[1] + mid + final + viva;
                    astudent.percentage = (astudent.total / 3);
                    if (astudent.percentage >= 80)
                    {
                        astudent.grade = "A+";
                    }
                    else if (astudent.percentage < 80 && astudent.percentage > 75)
                    {
                        astudent.grade = "A";
                    }
                    else if (astudent.percentage < 75 && astudent.percentage > 70)
                    {
                        astudent.grade = "A-";
                    }
                    else if (astudent.percentage < 70 && astudent.percentage > 65)
                    {
                        astudent.grade = "B+";
                    }
                    else if (astudent.percentage < 65 && astudent.percentage > 60)
                    {
                        astudent.grade = "B";
                    }
                    else if (astudent.percentage < 60 && astudent.percentage > 55)
                    {
                        astudent.grade = "C";
                    }
                    else if (astudent.percentage < 55 && astudent.percentage > 50)
                    {
                        astudent.grade = "D";
                    }
                    else
                    {
                       astudent.grade = "F";
                    }


                    ListOfStudents.student.Add(astudent);
                    IDListBox.Items.Add(astudent.studentID);
                    NameListBox.Items.Add(astudent.name);
                    PercentageListBox.Items.Add(Convert.ToString(Math.Round(astudent.percentage, 2)));
                    GradeListBox.Items.Add(astudent.grade);




                }
            }


        }

        private void Search_Click(object sender, EventArgs e)
        {
            string id = SearchBox.Text;
            for (int i = 0 ; i < ListOfStudents.student.Count; i++)
            {
                //MessageBox.Show("Checked");

                if (id == ListOfStudents.student[i].studentID)
                {
                    Students dummy = ListOfStudents.student[i];
                    Attendance.Text = "Attendance" + ListOfStudents.student[i].attendance;
                    Quiz1.Text = "Quiz1" + ListOfStudents.student[i].quiz1;
                    Quiz2.Text = "Quiz2" + ListOfStudents.student[i].quiz2;
                    Quiz3.Text = "Quiz3" + ListOfStudents.student[i].quiz3;
                    Quiz4.Text = "Quiz4" + ListOfStudents.student[i].quiz4;

                    List<double> quizes2 = new List<double>();

                    quizes2.Add(dummy.quiz1);
                    quizes2.Add(dummy.quiz2);
                    quizes2.Add(dummy.quiz3);
                    quizes2.Add(dummy.quiz4);
                    quizes2.Sort();
                    double temp = 0;
                    for (int j = 1; j < 4; j++)
                    {
                        temp += quizes2[j];
                    }
                    QuizTotal.Text = "Quiz Total : " + temp;
                    Mid.Text = "Mid : " + dummy.mid;
                    Final.Text = "Final : " + dummy.final;
                    Viva.Text = "Viva : " + dummy.viva;
                    Total.Text = "Total : " + Math.Round(dummy.total, 2);
                    percentage.Text = "Percentage : " + Math.Round(dummy.percentage, 2);
                    Grade.Text = "Grade : " + dummy.grade;
                    break;
                }
            }
        }
    }
}
    

    
    

