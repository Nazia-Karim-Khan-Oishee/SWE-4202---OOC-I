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
namespace Lab10_SWE4202
{
    public partial class Form1 : Form
    {

        public List<User> users = new List<User>();
        public Form1()
        {
            InitializeComponent();
            using (var reader = new StreamReader(@"E:\Download\SWE4201\userInfo - userInfo.csv"))
            {
                //List<string> listA = new List<string>();
                // List<string> listB = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    //listA.Add(values[0]);
                    // listB.Add(values[1]);

                    User newuser = new User();
                    newuser.firstname = values[0];
                    newuser.lastname = values[1];
                   // newuser.company = values;
                    newuser.address = values[3];
                    newuser.city = values[4];
                    newuser.country = values[5];
                    newuser.state = values[6];
                    newuser.zip = values[7];
                    newuser.phone1 = values[8];
                    newuser.phone2 = values[9];
                    newuser.email = values[10];
                    users.Add(newuser);
                }
                showusers();
            }

            users.RemoveAt(0);
            void showusers()
            {
                listofusers.Items.Clear();
                foreach (User auser in users)
                {
                    listofusers.Items.Add(auser.getinfo());
                }
            }
            for(int i=0;i<users.Count;i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = users[i].firstname;
                dataGridView1.Rows[i].Cells[1].Value = users[i].lastname;
                dataGridView1.Rows[i].Cells[2].Value = users[i].address;
                dataGridView1.Rows[i].Cells[3].Value = users[i].city;
                dataGridView1.Rows[i].Cells[4].Value = users[i].country;
                dataGridView1.Rows[i].Cells[5].Value = users[i].state;
                dataGridView1.Rows[i].Cells[6].Value = users[i].zip;
                dataGridView1.Rows[i].Cells[7].Value = users[i].phone1;
                dataGridView1.Rows[i].Cells[8].Value = users[i].phone2;
                dataGridView1.Rows[i].Cells[9].Value = users[i].email;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int found = 0;
            string searchbyemail = Searchforemail.Text;
            foreach (User user in users)
            {
                if (user.email == searchbyemail)
                {
                    //MessageBox.Show("DONE");
                    found = 1;
                    ShowUser.Items.Add(user.getinfo());
                    using (StreamWriter writer = File.AppendText(@"E:\Download\SWE4201\Log.txt"))
                    {
                        writer.WriteLine($"{user.getinfo()} {DateTime.Now}");
                    }
                    return;
                }
            }
            if (found == 0)
            {
                MessageBox.Show("User not found");
                using (StreamWriter writer = File.AppendText(@"E:\Download\SWE4201\Log.txt"))
                {
                    writer.WriteLine(Searchforemail.Text + "  " + "User not found" + DateTime.Now);
                }
            }

        }

        private void ShowUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Searchforemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
