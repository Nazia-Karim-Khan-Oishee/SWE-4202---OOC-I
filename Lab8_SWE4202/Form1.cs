using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_SWE4202
{
    public partial class Form1 : Form
    {
        List<CurrentAccount> CurrentAccountlist = new List<CurrentAccount>();
        List<LoanAccount> LoanAccountlist = new List<LoanAccount>();
        List<SavingsAccount> SavingsAccountlist = new List<SavingsAccount>();
        public Form1()
        {
            InitializeComponent();
        }

        private void CurrAcc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CurrAcc.Checked)
            {
                CurrentAccount AcurrentAccount = new CurrentAccount();
                int deposit = Convert.ToInt32(PrimaryDeposit.Text);
                AcurrentAccount.setCurrentAccountBalance(deposit);
                AcurrentAccount.getID();
                AcurrentAccount.setinfo(NameTextBox.Text, ContactTextBox.Text);
                CurrentAccountlist.Add(AcurrentAccount);
                MessageBox.Show("A Current Account Created." +
                    "Account Number is" + AcurrentAccount.AccNO);
            }
            else if (SaveAcc.Checked)
            {
                SavingsAccount AsavingAccount = new SavingsAccount();
                int deposit = Convert.ToInt32(PrimaryDeposit.Text);
                if (deposit < 50000)
                {
                    MessageBox.Show("Account can not be created. Insufficient Deposit.");
                    return;
                }
                else
                {
                    AsavingAccount.setCurrentAccountBalance(deposit);
                    AsavingAccount.getID();
                    AsavingAccount.setinfo(NameTextBox.Text, ContactTextBox.Text);
                    SavingsAccountlist.Add(AsavingAccount);
                    MessageBox.Show("A Savings Account Created." +
                        "Account Number is" + AsavingAccount.AccNO);
                }
            }
            else if (LoanAcc.Checked)
            {
                LoanAccount AloanAccount = new LoanAccount();
                int deposit = Convert.ToInt32(PrimaryDeposit.Text);
                AloanAccount.setCurrentAccountBalance(deposit);
                AloanAccount.getID();
                AloanAccount.setinfo(NameTextBox.Text, ContactTextBox.Text);
                LoanAccountlist.Add(AloanAccount);
                MessageBox.Show("A Current Account Created." +
                    "Account Number is" + AloanAccount.AccNO);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int IDNumber = Convert.ToInt32(AccNumber.Text);
            foreach (CurrentAccount ACurrAccount in CurrentAccountlist)
            {
                if (AccNumber.Text == ACurrAccount.AccNO)
                {
                    int Balance = Convert.ToInt32(DepositAmount.Text);
                    if (Balance > 100000 )
                    {
                        MessageBox.Show("This Transaction can not be held.");
                    }
                    else
                    {
                        if (Balance < 0)
                        {
                            throw new NegativeCase("Error:Negative amount can not be deposited");
                        }
                        else
                        {
                            ACurrAccount.getBalance(Balance);
                            MessageBox.Show(" Transaction Done");
                        }
                    }
                    return;
                }
            }
            foreach (SavingsAccount ASavingsAccount in SavingsAccountlist)
            {
                if (AccNumber.Text == ASavingsAccount.AccNO)
                {
                    int Balance = Convert.ToInt32(DepositAmount.Text);
                    if (Balance < 0)
                    {
                        throw new NegativeCase("Error:Negative amount can not be deposited"); ;
                    }
                    else if(ASavingsAccount.TransactionNumber<ASavingsAccount.TransactionLimit)
                    {   
                        ASavingsAccount.getBalance(Balance);
                        ASavingsAccount.TransactionNumber++;
                        MessageBox.Show(" Transaction Done");
                    }
                    else
                    {
                        MessageBox.Show("Transaction Limit Exceded");
                    }
                    return;
                }
            }
            foreach (LoanAccount AloanAccount in LoanAccountlist)
            {
                if (AccNumber.Text == AloanAccount.AccNO)
                {
                    int Balance = Convert.ToInt32(DepositAmount.Text);
                    if (Balance < 0)
                    {
                        throw new NegativeCase("Error:Negative amount can not be deposited"); ;
                    }
                    else
                    {
                        AloanAccount.getBalance(Balance);
                        //MessageBox.Show(" Transaction Done");
                    }
                    return;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = AcNotoWithdraw.Text;
            foreach (CurrentAccount ACurrAccount in CurrentAccountlist)
            {
                if (ACurrAccount.AccNO == id)
                { int withdrawal = Convert.ToInt32(WithdrawAmount.Text);

                    if (withdrawal < 0)
                    {
                        throw new NegativeCase("Error:Negative amount can not be deposited");
                    }
                   else if (withdrawal > 100000 || withdrawal>ACurrAccount.Balance)
                    {
                       // if(ACurrAccount)
                        MessageBox.Show("This Transaction can not be held");
                    }
                    else
                    {
                        ACurrAccount.getNewBalance(withdrawal);

                    }
                    return;
                }
            }
            foreach (SavingsAccount ASavingAccount in SavingsAccountlist)
            {
                if (ASavingAccount.AccNO == id)
                {
                    int withdrawal = Convert.ToInt32(WithdrawAmount.Text);
                    if (withdrawal < 0)
                    {
                        throw new NegativeCase("Error:Negative amount can not be deposited");
                    }
                  else  if (withdrawal > ASavingAccount.Balance)
                    {
                        // if(ACurrAccount)
                        MessageBox.Show("This Transaction can not be held");
                    }
                    else if (ASavingAccount.TransactionNumber < ASavingAccount.TransactionLimit)
                    {
                        ASavingAccount.getNewBalance(withdrawal+15);
                        ASavingAccount.TransactionNumber++;
                        MessageBox.Show("Transaction Done.");
                    }
                    else
                    {
                        MessageBox.Show("Transaction Limit Exceded");
                    }
                    return;
                }
            }
            foreach (LoanAccount AloanAccount in LoanAccountlist)
            {
                if (AloanAccount.AccNO == id)
                {
                    MessageBox.Show("This Transaction Can Not Be Held.");
                    
                    return;
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            string account = CheckAccNo.Text;
            foreach (LoanAccount AloanAccount in LoanAccountlist)
            {
                if (AloanAccount.AccNO == account)
                {
                    listBox.Items.Add(AloanAccount.Name+"\t+" + AloanAccount.AccNO+"\t"+"Current Balance:"+ AloanAccount.Balance);

                    return;
                }
            }
            foreach (CurrentAccount AcurrAccount in CurrentAccountlist)
            {
                if (AcurrAccount.AccNO == account)
                {
                    listBox.Items.Add(AcurrAccount.Name+"\t"+AcurrAccount.AccNO + "\t" +"CurrentBalance:" +AcurrAccount.Balance);

                    return;
                }
            }
            foreach (SavingsAccount AsavingAccount in SavingsAccountlist)
            {
                if (AsavingAccount.AccNO == account)
                {
                    listBox.Items.Add(AsavingAccount.Name+"\t"+AsavingAccount.AccNO + "\t" + "Current Balance:"+AsavingAccount.Balance);

                    return;
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    } }
