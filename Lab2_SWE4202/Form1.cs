using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_SWE4202
{
    public partial class InformationManagment : Form
    {
        List<Student> students = new List<Student>();
        List<Teacher> teachers = new List<Teacher>();
        List<Administrator> adm = new List<Administrator>();

        public InformationManagment()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearonClickStudentInfo(object sender, EventArgs e)
        {
            StudentIDTextBox.Text = String.Empty;
            StudentNameTextBox.Text = String.Empty;
            StudentDeptTextBox.Text = String.Empty;
            StudentSemesterTextBox.Text = String.Empty;
        }

        private void SaveonClickStudentInfo(object sender, EventArgs e)
        {
            string studentid = StudentIDTextBox.Text;
            string studentname = StudentNameTextBox.Text;
            string studentdept = StudentDeptTextBox.Text;
            string studentsemester = StudentSemesterTextBox.Text;

            Student dummystudent = new Student();
            dummystudent.setstudentid(studentid);
            dummystudent.setstudentname(studentname);
            dummystudent.setstudentdept(studentdept);
            dummystudent.setstudentsem(studentsemester);
            students.Add(dummystudent);
            MessageBox.Show("Student Information has been saved.");
        }

        private void ShowStudentListonClick(object sender, EventArgs e)
        {
            StudentInfo.Items.Clear();
            for(int i=0;i<students.Count;i++)
            { 
                StudentInfo.Items.Add(students[i].getstudentinfo());
            }
        }

        private void InformationManagment_Load(object sender, EventArgs e)
        {

        }

        private void SvaeTeacherInfoonClick(object sender, EventArgs e)
        {
            string Tid = TeacherIdTextBox.Text;
            string Tname = TeacherNameTextBox.Text;
            string Tdept = TeacherDeptTextBox.Text;
            string Tdesg = TeacherDesignationTextBox.Text;
            string TSalary = TeacherSalaryTextBox.Text;

            Teacher dummyT = new Teacher();
            dummyT.TeacherID = Tid;
            dummyT.TeacherName = Tname;
            dummyT.TeacherDesignation = Tdesg;
            dummyT.TeacherDept = Tdept;
            dummyT.TeacherSalary = TSalary;
            teachers.Add(dummyT);
            MessageBox.Show("Student Information has been saved.");
        }

        private void ShowTeacherListonClick(object sender, EventArgs e)
        {
            TeacherInfo.Items.Clear();
            for (int i = 0; i < teachers.Count; i++)
            {
                TeacherInfo.Items.Add(teachers[i].getTeacherinfo());
            }
        }

        private void ClearAdmInfoonClick(object sender, EventArgs e)
        {
           AdmID.Text = String.Empty;
            AdmName.Text = String.Empty;
            AdmDesignation.Text = String.Empty;
            AdmSalary.Text = String.Empty;
        }

        private void CleaeTeacherInfoOnClick(object sender, EventArgs e)
        {
            TeacherIdTextBox.Text = String.Empty;
           TeacherNameTextBox.Text = String.Empty;
            TeacherDeptTextBox.Text = String.Empty;
            TeacherDesignationTextBox.Text = String.Empty;
            TeacherSalaryTextBox.Text = String.Empty;   
        }

        private void SaveAdmInfoonClick(object sender, EventArgs e)
        {
            string Adid = AdmID.Text;
            string Adname = AdmName.Text;
            string Addesg = AdmDesignation.Text;
            string AdSalary = AdmSalary.Text;

            Administrator dummyA = new Administrator();
            dummyA.AdmID = Adid;
            dummyA.AdmName = Adname;
            dummyA.AdmDesignation = Addesg;
             dummyA.AdmSalary = AdSalary;
            adm.Add(dummyA);
            MessageBox.Show("Student Information has been saved.");
        }

        private void ShowAdmListonClick(object sender, EventArgs e)
        {
            AdministratorInfo.Items.Clear();
            for (int i = 0; i < adm.Count; i++)
            {
                AdministratorInfo.Items.Add(adm[i].getAdminfo());
            }
        }
    }
}
