using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment1
{
    public partial class GradeApps : Form
    {
        public GradeApps()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Numberofclasses_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Final_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalculateGrade_Click(object sender, EventArgs e)
        {   if (NameTextBox.Text != "" && IDTextBox.Text != "" && SemesterTextBox.Text != "" &&
                   NumberofclassesTextBox.Text != "" && MidTextBox.Text != "" && FinalTextBox.Text != "" &&
                   Quiz1TextBox.Text != "" && Quiz2TextBox.Text != "" && Quiz3TextBox.Text != "" &&
                   Quiz4TextBox.Text != "")
            {
                string Name = NameTextBox.Text;
                int ID = Convert.ToInt32(IDTextBox.Text);
                int Semester = Convert.ToInt32(SemesterTextBox.Text);
                int NumberofClasses = Convert.ToInt32(NumberofclassesTextBox.Text);
                double MidMarks = Convert.ToDouble(MidTextBox.Text);
                double FinalMarks = Convert.ToDouble(FinalTextBox.Text);
                double Quiz1 = Convert.ToDouble(Quiz1TextBox.Text);
                double Quiz2 = Convert.ToDouble(Quiz2TextBox.Text);
                double Quiz3 = Convert.ToDouble(Quiz3TextBox.Text);
                double Quiz4 = Convert.ToDouble(Quiz4TextBox.Text);
                double AttendedClasses = Convert.ToDouble(NumberofClasses);
                double Attendance = (AttendedClasses / 28) * 30;
                double[] ArrayofQuiz = { Quiz1, Quiz2, Quiz3, Quiz4 };
                Array.Sort(ArrayofQuiz);
                double QuizTotal = 0;
                for (int i = 1; i < ArrayofQuiz.Length; i++)
                {
                    QuizTotal = QuizTotal + ArrayofQuiz[i];
                }
                AttendanceLabel.Text = "Attendance: " + Math.Round(Attendance, 2) + "/30";
                MidLabel.Text = "Mid: " + MidMarks + "/75";
                QuizLabel.Text = "Quiz: " + QuizTotal + "/45";
                FinalLabel.Text = "Final: " + FinalMarks + "/150";
                double Total = Attendance + MidMarks + QuizTotal + FinalMarks;
                TotalLabel.Text = "Total: " + Math.Round(Total, 2) + "/300";
                double MarksinPercantage = (Total / 300) * 100;

                string Grade=null;
                if (MarksinPercantage >=80)
                {
                    Grade = "A+";
                }
                else if (MarksinPercantage >=75 && MarksinPercantage <80)
                {
                    Grade = "A";
                }
                else if (MarksinPercantage >= 70 && MarksinPercantage < 75)
                {
                    Grade = "A-";
                }
                else if (MarksinPercantage >= 65 && MarksinPercantage < 70)
                {
                    Grade = "B+";
                }
                else if (MarksinPercantage >= 60 && MarksinPercantage < 65)
                {
                    Grade = "B";
                }
                else if (MarksinPercantage >= 55 && MarksinPercantage < 60)
                {
                    Grade = "B-";
                }
                else if (MarksinPercantage >= 50 && MarksinPercantage < 55)
                {
                    Grade = "C+";
                }
                else if (MarksinPercantage >= 45 && MarksinPercantage < 50)
                {
                    Grade = "C";
                }
                else if (MarksinPercantage >= 40 && MarksinPercantage < 45)
                {
                    Grade = "D";
                }
                else
                {
                    Grade = "F";
                }
                GradeLabel.Text = "Grade: " + Grade;
                LastLineLabel.Text = Name + " obtained " + Math.Round(MarksinPercantage, 2) + "% marks.";
            }
        else
            {
                MessageBox.Show("Error!" + "\n" + "Fill all necessary data.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FinalLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
