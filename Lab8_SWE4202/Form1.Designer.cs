namespace Lab8_SWE4202
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.CurrAcc = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoanAcc = new System.Windows.Forms.RadioButton();
            this.SaveAcc = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PrimaryDeposit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AccNumber = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.AcNotoWithdraw = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.DepositAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.WithdrawAmount = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CheckAccNo = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ContactTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account Type:";
            // 
            // CurrAcc
            // 
            this.CurrAcc.AutoSize = true;
            this.CurrAcc.Location = new System.Drawing.Point(18, 3);
            this.CurrAcc.Name = "CurrAcc";
            this.CurrAcc.Size = new System.Drawing.Size(121, 20);
            this.CurrAcc.TabIndex = 0;
            this.CurrAcc.TabStop = true;
            this.CurrAcc.Text = "Current Account";
            this.CurrAcc.UseVisualStyleBackColor = true;
            this.CurrAcc.CheckedChanged += new System.EventHandler(this.CurrAcc_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LoanAcc);
            this.panel1.Controls.Add(this.SaveAcc);
            this.panel1.Controls.Add(this.CurrAcc);
            this.panel1.Location = new System.Drawing.Point(144, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 117);
            this.panel1.TabIndex = 3;
            // 
            // LoanAcc
            // 
            this.LoanAcc.AutoSize = true;
            this.LoanAcc.Location = new System.Drawing.Point(18, 77);
            this.LoanAcc.Name = "LoanAcc";
            this.LoanAcc.Size = new System.Drawing.Size(109, 20);
            this.LoanAcc.TabIndex = 2;
            this.LoanAcc.TabStop = true;
            this.LoanAcc.Text = "Loan Account";
            this.LoanAcc.UseVisualStyleBackColor = true;
            this.LoanAcc.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // SaveAcc
            // 
            this.SaveAcc.AutoSize = true;
            this.SaveAcc.Location = new System.Drawing.Point(18, 38);
            this.SaveAcc.Name = "SaveAcc";
            this.SaveAcc.Size = new System.Drawing.Size(128, 20);
            this.SaveAcc.TabIndex = 1;
            this.SaveAcc.TabStop = true;
            this.SaveAcc.Text = "Savings Account";
            this.SaveAcc.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Create Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Deposit:";
            // 
            // PrimaryDeposit
            // 
            this.PrimaryDeposit.Location = new System.Drawing.Point(157, 291);
            this.PrimaryDeposit.Name = "PrimaryDeposit";
            this.PrimaryDeposit.Size = new System.Drawing.Size(100, 22);
            this.PrimaryDeposit.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(502, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Account NO:";
            // 
            // AccNumber
            // 
            this.AccNumber.Location = new System.Drawing.Point(644, 53);
            this.AccNumber.Name = "AccNumber";
            this.AccNumber.Size = new System.Drawing.Size(100, 22);
            this.AccNumber.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(539, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 40);
            this.button2.TabIndex = 9;
            this.button2.Text = "Deposit Money";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(891, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Account NO:";
            // 
            // AcNotoWithdraw
            // 
            this.AcNotoWithdraw.Location = new System.Drawing.Point(1023, 56);
            this.AcNotoWithdraw.Name = "AcNotoWithdraw";
            this.AcNotoWithdraw.Size = new System.Drawing.Size(100, 22);
            this.AcNotoWithdraw.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(936, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 43);
            this.button3.TabIndex = 12;
            this.button3.Text = "Withdraw Money";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(502, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Amount:";
            // 
            // DepositAmount
            // 
            this.DepositAmount.Location = new System.Drawing.Point(644, 88);
            this.DepositAmount.Name = "DepositAmount";
            this.DepositAmount.Size = new System.Drawing.Size(100, 22);
            this.DepositAmount.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(891, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Amount:";
            // 
            // WithdrawAmount
            // 
            this.WithdrawAmount.Location = new System.Drawing.Point(1023, 91);
            this.WithdrawAmount.Name = "WithdrawAmount";
            this.WithdrawAmount.Size = new System.Drawing.Size(100, 22);
            this.WithdrawAmount.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(12, 393);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1324, 18);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(437, 434);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Account NO:";
            // 
            // CheckAccNo
            // 
            this.CheckAccNo.Location = new System.Drawing.Point(607, 434);
            this.CheckAccNo.Name = "CheckAccNo";
            this.CheckAccNo.Size = new System.Drawing.Size(100, 22);
            this.CheckAccNo.TabIndex = 19;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(345, 494);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(521, 164);
            this.listBox.TabIndex = 20;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(555, 689);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 43);
            this.button4.TabIndex = 21;
            this.button4.Text = "Show";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(419, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 411);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox3.Location = new System.Drawing.Point(824, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 411);
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "Contact NO:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(157, 196);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 22);
            this.NameTextBox.TabIndex = 26;
            // 
            // ContactTextBox
            // 
            this.ContactTextBox.Location = new System.Drawing.Point(157, 243);
            this.ContactTextBox.Name = "ContactTextBox";
            this.ContactTextBox.Size = new System.Drawing.Size(100, 22);
            this.ContactTextBox.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 767);
            this.Controls.Add(this.ContactTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.CheckAccNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.WithdrawAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DepositAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.AcNotoWithdraw);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AccNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PrimaryDeposit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Banking System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton CurrAcc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton LoanAcc;
        private System.Windows.Forms.RadioButton SaveAcc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PrimaryDeposit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AccNumber;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AcNotoWithdraw;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DepositAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox WithdrawAmount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CheckAccNo;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox ContactTextBox;
    }
}

