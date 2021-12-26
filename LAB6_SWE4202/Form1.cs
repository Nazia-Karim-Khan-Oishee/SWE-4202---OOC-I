using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB6_SWE4202
{
    public partial class Form1 : Form
    {
        internal List<User>userlist = new List<User>();
        internal List<Order>orderlist = new List<Order>();

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string  id = OrderID.Text;
            int flag = 0;
            foreach(Order order in orderlist)
            {
                if(order.OrderId == id)
                {
                    order.Status = StatusCombo.Text;
                    flag = 1;
                }
                CurrBalance.Text = "Current Balance: " + 
                    Convert.ToString(Calculate.totalamount);
                MessageBox.Show("Status Updated.");
            }
            if (flag==0)
            {
                MessageBox.Show("This Order can not be found.");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string uid = UID.Text;
            int f = 0;
            foreach(User user in userlist)
            {
                if(user.userId == uid)
                {
                    f = 1;
                    user.userBedSheet = Convert.ToInt32(SheetNumber.Text);
                    user.userShirt = Convert.ToInt32(ShirtNumber.Text);
                    user.userPant = Convert.ToInt32(PantNumber.Text);
                    user.userSuit = Convert.ToInt32(SuitNumber.Text);
                    user.shirtCondition = ShirtCombo.Text;
                    user.pantCondition = PantCombo.Text;
                    user.suitCondition = SuitCombo.Text;
                    user.BedSheetCondition = SheetCombo.Text;
                    MessageBox.Show("Order Placed." + "\n" + "Order ID " +
                     Convert.ToString(Calculate.orderID));
                    int price = 0;
                    if (ShirtCombo.Text != "")
                    {
                        if (ShirtCombo.Text == "Both")
                        {
                            price = price + 50 * Convert.ToInt32(ShirtNumber.Text);
                        }
                        else if (ShirtCombo.Text == "Wash")
                        {
                            price = price + 50 * Convert.ToInt32(ShirtNumber.Text);
                        }
                        else
                        {
                            price = price + 50 * Convert.ToInt32(ShirtNumber.Text);
                        }
                    }
                    if (PantCombo.Text != "")
                    {
                        if (PantCombo.Text == "Both")
                        {
                            price = price + 50 * Convert.ToInt32(PantNumber.Text);
                        }
                        else if (PantCombo.Text == "Wash")
                        {
                            price = price + 50 * Convert.ToInt32(PantNumber.Text);
                        }
                        else
                        {
                            price = price + 50 * Convert.ToInt32(PantNumber.Text);
                        }
                    }
                    if (SuitCombo.Text != "")
                    {
                        if (SuitCombo.Text == "Both")
                        {
                            price = price + 50 * Convert.ToInt32(SuitNumber.Text);
                        }
                        else if (SuitCombo.Text == "Wash")
                        {
                            price = price + 50 * Convert.ToInt32(SuitNumber.Text);
                        }
                        else
                        {
                            price = price + 50 * Convert.ToInt32(SuitNumber.Text);
                        }
                    }
                    if (SheetCombo.Text != "")
                    {
                        if (SheetCombo.Text == "Both")
                        {
                            price = price + 50 * Convert.ToInt32(SheetNumber.Text);
                        }
                        else if (SheetCombo.Text == "Wash")
                        {
                            price = price + 50 * Convert.ToInt32(SheetNumber.Text);
                        }
                        else
                        {
                            price = price + 50 * Convert.ToInt32(SheetNumber.Text);
                        }
                    }
                    user.amount = user.amount + price;
                    Calculate.totalamount = Calculate.totalamount + price;
                    Order neworder = new Order();
                    neworder.setUser(user);
                    neworder.setOrderId(Convert.ToString(Calculate.orderID));
                    orderlist.Add(neworder);
                    //MessageBox.Show("Order Placed!");
                    Calculate.orderID++;
                    break;
                }
            }
                if(f==0)
            {
                MessageBox.Show("This User Can Not Be Found.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.userName = UserName.Text;
            user.userId = UserID.Text;
            user.userAdddress = UserAdd.Text;
            userlist.Add(user);
            MessageBox.Show("User Added");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(CheckOrderID.Text);
            List.Items.Clear();
            foreach(Order order in orderlist)
            {
                if (id == Convert.ToInt32(order.OrderId))
                {

                    List.Items.Add(order.listShow());
                    Amount.Text = " Amount : " + Convert.ToString(order.user.amount);
                    Status.Text = "Status : " + order.Status;
                    Name.Text = "Name : " + order.user.userName;
                    Address.Text = "Address : " + order.user.userAdddress;
                }
            }
        }
    }
}
