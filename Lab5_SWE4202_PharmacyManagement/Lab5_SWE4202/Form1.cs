using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmacyManagement;
namespace Lab5_SWE4202
{
    public partial class Form1 : Form
    {
        public List<Medicine> listofmed = new List<Medicine>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            int flag = 0;
            foreach (Medicine medicine in listofmed)
            {
                if (medicine.getid() == MedID.Text)
                {
                    medicine.setinquantity(Convert.ToInt32(Inquantity.Text));
                    flag = 1;
                    MessageBox.Show("Medicine quantity has been updated.");
                    break;
                }
            }
            if (flag == 0)
            {
                Medicine medicine1 = new Medicine(MedicineName.Text, MedID.Text, Convert.ToInt32(Price.Text), Convert.ToInt32(Inquantity.Text));
                listofmed.Add(medicine1);
                MessageBox.Show("This medicine has been added.");
            }
                
        }

        private void Sell_Click(object sender, EventArgs e)
        {
            string sellid = MedicineID.Text;
            foreach (Medicine medicine in listofmed)
            {
                if (medicine.getid() == sellid)
                {
                    if (medicine.getcurrentquantity() >= Convert.ToInt32(soldq.Text))
                    {
                        medicine.setsoldquan(Convert.ToInt32(soldq.Text));
                        medicine.setcurrentquantity(Convert.ToInt32(soldq.Text));
                        medicine.setcurrentamount();
                        MessageBox.Show("Medicine Sold.");
                        break;
                    }
                    else
                    {
                        MessageBox.Show("This medicine cannot be sold!");
                        break;
                    }
                }
            }
        }

        private void Show_Click(object sender, EventArgs e)
        {
            foreach (Medicine medicine in listofmed)
            { 
                if (medicine.getid() == CheckID.Text)
                {
                    if (medicine.getsoldquantity()!= 0)
                    { 
                        CurrQ.Text = "Current Quantity: " + Convert.ToString(medicine.getcurrentquantity());
                    }
                    else
                    {
                        CurrQ.Text = "Current Quantity: " + Convert.ToString(medicine.getinquantity());
                    }
                    break;
                }

            }
        }

        private void ShowBalance_Click(object sender, EventArgs e)
        {
            int total =0;
            foreach (Medicine medicine in listofmed)
            {
                 medicine.setcurrentamount();
             total = total + (medicine.getcurrentamount());
            }
            //CurrBalance.Text =
            MessageBox.Show("Current Balance: " + total.ToString());
        }
    }
}
