namespace LAB3_SWE4201
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
            this.BookID = new System.Windows.Forms.TextBox();
            this.Uadd = new System.Windows.Forms.TextBox();
            this.Bname = new System.Windows.Forms.TextBox();
            this.Useridtxt = new System.Windows.Forms.TextBox();
            this.Bauthor = new System.Windows.Forms.TextBox();
            this.Uname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Bquantity = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.user2 = new System.Windows.Forms.TextBox();
            this.book2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.IDlabel = new System.Windows.Forms.Label();
            this.labelQ = new System.Windows.Forms.Label();
            this.UIH = new System.Windows.Forms.TextBox();
            this.BIH = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.listBoxforUsers = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // BookID
            // 
            this.BookID.Location = new System.Drawing.Point(451, 45);
            this.BookID.Name = "BookID";
            this.BookID.Size = new System.Drawing.Size(100, 22);
            this.BookID.TabIndex = 0;
            this.BookID.TextChanged += new System.EventHandler(this.BookID_TextChanged);
            // 
            // Uadd
            // 
            this.Uadd.Location = new System.Drawing.Point(141, 131);
            this.Uadd.Name = "Uadd";
            this.Uadd.Size = new System.Drawing.Size(100, 22);
            this.Uadd.TabIndex = 1;
            // 
            // Bname
            // 
            this.Bname.Location = new System.Drawing.Point(451, 87);
            this.Bname.Name = "Bname";
            this.Bname.Size = new System.Drawing.Size(100, 22);
            this.Bname.TabIndex = 2;
            this.Bname.TextChanged += new System.EventHandler(this.Bname_TextChanged);
            // 
            // Useridtxt
            // 
            this.Useridtxt.Location = new System.Drawing.Point(141, 43);
            this.Useridtxt.Name = "Useridtxt";
            this.Useridtxt.Size = new System.Drawing.Size(100, 22);
            this.Useridtxt.TabIndex = 3;
            // 
            // Bauthor
            // 
            this.Bauthor.Location = new System.Drawing.Point(451, 131);
            this.Bauthor.Name = "Bauthor";
            this.Bauthor.Size = new System.Drawing.Size(100, 22);
            this.Bauthor.TabIndex = 4;
            this.Bauthor.TextChanged += new System.EventHandler(this.Bauthor_TextChanged);
            // 
            // Uname
            // 
            this.Uname.Location = new System.Drawing.Point(141, 87);
            this.Uname.Name = "Uname";
            this.Uname.Size = new System.Drawing.Size(100, 22);
            this.Uname.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "User ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Book Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Book ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(346, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Author:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(346, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Quantity:";
            // 
            // Bquantity
            // 
            this.Bquantity.Location = new System.Drawing.Point(451, 168);
            this.Bquantity.Name = "Bquantity";
            this.Bquantity.Size = new System.Drawing.Size(100, 22);
            this.Bquantity.TabIndex = 14;
            this.Bquantity.TextChanged += new System.EventHandler(this.Bquantity_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GrayText;
            this.pictureBox1.Location = new System.Drawing.Point(294, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 255);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.GrayText;
            this.pictureBox2.Location = new System.Drawing.Point(22, 284);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(506, 13);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 358);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "User ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(346, 358);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Book ID:";
            // 
            // user2
            // 
            this.user2.Location = new System.Drawing.Point(141, 358);
            this.user2.Name = "user2";
            this.user2.Size = new System.Drawing.Size(100, 22);
            this.user2.TabIndex = 20;
            this.user2.TextChanged += new System.EventHandler(this.user2_TextChanged);
            // 
            // book2
            // 
            this.book2.Location = new System.Drawing.Point(418, 358);
            this.book2.Name = "book2";
            this.book2.Size = new System.Drawing.Size(100, 22);
            this.book2.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(863, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "User History";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(695, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "User ID:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(863, 321);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 16);
            this.label13.TabIndex = 24;
            this.label13.Text = "Book History";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(705, 364);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 16);
            this.label14.TabIndex = 26;
            this.label14.Text = "Book ID:";
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(705, 404);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(79, 16);
            this.Namelabel.TabIndex = 27;
            this.Namelabel.Text = "BookName:";
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(705, 445);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(55, 16);
            this.IDlabel.TabIndex = 28;
            this.IDlabel.Text = "BookID:";
            // 
            // labelQ
            // 
            this.labelQ.AutoSize = true;
            this.labelQ.Location = new System.Drawing.Point(705, 480);
            this.labelQ.Name = "labelQ";
            this.labelQ.Size = new System.Drawing.Size(58, 16);
            this.labelQ.TabIndex = 29;
            this.labelQ.Text = "Quantity:";
            // 
            // UIH
            // 
            this.UIH.Location = new System.Drawing.Point(800, 96);
            this.UIH.Name = "UIH";
            this.UIH.Size = new System.Drawing.Size(100, 22);
            this.UIH.TabIndex = 30;
            // 
            // BIH
            // 
            this.BIH.Location = new System.Drawing.Point(823, 364);
            this.BIH.Name = "BIH";
            this.BIH.Size = new System.Drawing.Size(100, 22);
            this.BIH.TabIndex = 31;
            this.BIH.TextChanged += new System.EventHandler(this.BIH_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1214, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.UHShow);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1214, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "Show";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(377, 240);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 34;
            this.button3.Text = "Add Book";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(262, 480);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 23);
            this.button4.TabIndex = 35;
            this.button4.Text = "Borrow Book:";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(116, 240);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 36;
            this.button5.Text = "Add User";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.GrayText;
            this.pictureBox3.Location = new System.Drawing.Point(612, 33);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 508);
            this.pictureBox3.TabIndex = 37;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.GrayText;
            this.pictureBox4.Location = new System.Drawing.Point(522, 284);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(850, 13);
            this.pictureBox4.TabIndex = 38;
            this.pictureBox4.TabStop = false;
            // 
            // listBoxforUsers
            // 
            this.listBoxforUsers.FormattingEnabled = true;
            this.listBoxforUsers.ItemHeight = 16;
            this.listBoxforUsers.Location = new System.Drawing.Point(698, 140);
            this.listBoxforUsers.Name = "listBoxforUsers";
            this.listBoxforUsers.Size = new System.Drawing.Size(647, 116);
            this.listBoxforUsers.TabIndex = 39;
            this.listBoxforUsers.SelectedIndexChanged += new System.EventHandler(this.listBoxforUsers_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 665);
            this.Controls.Add(this.listBoxforUsers);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BIH);
            this.Controls.Add(this.UIH);
            this.Controls.Add(this.labelQ);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.book2);
            this.Controls.Add(this.user2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Bquantity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Uname);
            this.Controls.Add(this.Bauthor);
            this.Controls.Add(this.Useridtxt);
            this.Controls.Add(this.Bname);
            this.Controls.Add(this.Uadd);
            this.Controls.Add(this.BookID);
            this.Name = "Form1";
            this.Text = "Library Managment";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BookID;
        private System.Windows.Forms.TextBox Uadd;
        private System.Windows.Forms.TextBox Bname;
        private System.Windows.Forms.TextBox Useridtxt;
        private System.Windows.Forms.TextBox Bauthor;
        private System.Windows.Forms.TextBox Uname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Bquantity;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox user2;
        private System.Windows.Forms.TextBox book2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label labelQ;
        private System.Windows.Forms.TextBox UIH;
        private System.Windows.Forms.TextBox BIH;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ListBox listBoxforUsers;
    }
}

