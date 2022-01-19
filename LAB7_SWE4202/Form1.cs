using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB7_SWE4202
{
    public partial class StudentCourseEnrollment : Form
    {
        List<Student> studentlist = new List<Student>();
        List<Professional> professionallist = new List<Professional>();
        List<Course> courselist = new List<Course>();
        public StudentCourseEnrollment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TypeStudent.Checked)
            {
                string level;
                if (TypeBegin.Checked)
                {
                    level = "Beginner";
                }
                else if (TypeInter.Checked)
                {
                    level = "Intermediate";
                }
                else
                {
                    level = "Advanced";
                }
                Enroll.Items.Add(RegNo.Text);
                Student Astudent = new Student(ParticipantName.Text, RegNo.Text, ParticipantContact.Text,
                    ParticipantEmail.Text, level);
                studentlist.Add(Astudent);
                MessageBox.Show("Participant Added!");
            }
            else if (TypeProffesional.Checked)
            {
                string level;
                if (TypeBegin.Checked)
                {
                    level = "Beginner";
                }
                else if (TypeInter.Checked)
                {
                    level = "Intermediate";
                }
                else
                {
                    level = "Advanced";
                }
                Enroll.Items.Add(RegNo.Text);
                Professional Aprofessional = new Professional(ParticipantName.Text, RegNo.Text, ParticipantContact.Text,
                    ParticipantEmail.Text, level);
                professionallist.Add(Aprofessional);
                MessageBox.Show("Participant Added!");
            }
        }

        private void TypeInter_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TypeBegin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void StudentCourseEnrollment_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            string courselevel;
            if (BeginnerCourse.Checked)
            {
                courselevel = "Beginner";
            }
            else if (IntermediateCourse.Checked)
            {
                courselevel = "Intermediate";
            }
            else
            {
                courselevel = "Advanced";
            }
            Courseforenroll.Items.Add(CourseTitle.Text);
            Course Acourse = new Course(CourseTitle.Text, courselevel,
                Convert.ToInt32(FeeforCourse.Text));
            courselist.Add(Acourse);
            MessageBox.Show("Course Added");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // int flag = 0;
            

            foreach (Student astudent in studentlist)
            {
                astudent.date = Date.Text;
                if (astudent.RegistrationNo == Enroll.Text)
                {
                    foreach (Course course in courselist)
                    {
                        if (course.name == Courseforenroll.Text)
                        {
                           // MessageBox.Show("Found Course");

                            if (astudent.Level == course.level )
                            {
                               // MessageBox.Show("Found level");
                                astudent.listofcourses.Add(course);

                                //{
                                // if (course.name == Courseforenroll.Text)
                                // {
                                astudent.setfee(course.fee);
                                // }
                                CourseFee.Text = "Course Fee" + " " + Convert.ToString(course.fee);
                                //}
                                //flag = 1;
                                return;
                            }
                        else
                        {
                            MessageBox.Show("This Course Can Not Be Enrolled");
                            //flag = 1;
                            /*if(astudent.Level != null)
                                        {
                                            flag = 1;
                                        }*/
                            return;
                        }
                        }

                    }
                }
            }

           

            foreach (Professional aprofessional in professionallist)
            {
                aprofessional.date = Date.Text;
                if (aprofessional.RegistrationNo == Enroll.Text)
                {
                    foreach (Course course in courselist)
                    {
                        if (course.name == Courseforenroll.Text)
                        {
                            // MessageBox.Show("Found Course");

                            if (aprofessional.Level == course.level)
                            {
                                // MessageBox.Show("Found level");
                                aprofessional.listofcourses.Add(course);

                                //{
                                // if (course.name == Courseforenroll.Text)
                                // {
                                aprofessional.setfee(course.fee);
                                // }
                                CourseFee.Text = "Course Fee" + " " + Convert.ToString(course.fee);
                                //}
                            }
                        
                        else
                        {
                            MessageBox.Show("This Course Can Not Be Enrolled");
                        }
                    }
                    }
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ParticipantList.Items.Clear();
            string CheckName = CheckStudent.Text;

            foreach(Student student in studentlist)
            {
                if(student.Name == CheckName)
                {
                    foreach(Course course in student.listofcourses)
                    {
                        ParticipantList.Items.Add(student.Name + "\t" + student.Level+"\t"+course.name);

                    }
                    return;
                }
            }

            foreach (Professional aprofessional in professionallist)
            {
                if (aprofessional.Name == CheckName)
                {
                    foreach (Course course in aprofessional.listofcourses)
                    {
                        ParticipantList.Items.Add(aprofessional.Name + "\t" + aprofessional.Level + "\t" + course.name);

                    }
                    return;
                }
            }

        }

        
    }
}