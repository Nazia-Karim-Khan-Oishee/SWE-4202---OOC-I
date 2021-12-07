using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB3_SWE4201
{
    public partial class Form1 : Form
    {
        List<Book> booklist = new List<Book>();
        List<User> userlist = new List<User>();
        public Form1()
        {
            InitializeComponent();
        }

        private void UHShow(object sender, EventArgs e)
        {
            listBoxforUsers.Items.Clear();
            foreach(User user in userlist)
            {
                if(user.getuid( ) == UIH.Text)
                {
                    foreach(Book book in user.books)
                    {
                        listBoxforUsers.Items.Add(book.getbooklist());
                    }
                }
            }
        }

        private void BHShow(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string uid = Useridtxt.Text;
            string Name = Uname.Text;
            String Address = Uadd.Text;

            User user = new User(uid,Name, Address);
           userlist.Add(user);
            MessageBox.Show("This User Has been Added");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Book book = new Book(BookID.Text,Bname.Text, Bauthor.Text, Convert.ToInt32(Bquantity.Text ));
            booklist.Add(book);
            MessageBox.Show("This book has been added");
        }

        private void BookID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bauthor_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bquantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {   
            Book temp = new Book();
            foreach (Book book in booklist)
            {
                if (book.getbid() == book2.Text)
                {
                    if (book.getbquantity() == "0")
                    {
                        MessageBox.Show("This book is not available");
                        return;
                    }
                    else
                    {
                        temp = book;
                    }
                }
            }
            foreach (User user in userlist)
            {
                if(user.getuid()==user2.Text)
                {
                    user.setlist(temp);
                    temp.decrement();
                }
            }

        }

        private void user2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxforUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Book book in booklist)
            {
                if (book.getbid() == BIH.Text)
                {
                    Namelabel.Text = "BookName: " + book.getname() ;
                    IDlabel.Text = "BookID: " + book.getbid();
                    labelQ.Text = "Quantity: " + book.getbquantity();
                }
            }
        }

        private void BIH_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
