namespace Lab4_SWE4201
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AddBook = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.BID = new System.Windows.Forms.TextBox();
            this.BTitle = new System.Windows.Forms.TextBox();
            this.BAth = new System.Windows.Forms.TextBox();
            this.BPublisher = new System.Windows.Forms.TextBox();
            this.BQuantity = new System.Windows.Forms.TextBox();
            this.ISBNtxtbox = new System.Windows.Forms.TextBox();
            this.Genre = new System.Windows.Forms.TextBox();
            this.Datetxtbox = new System.Windows.Forms.TextBox();
            this.CJtxtbox = new System.Windows.Forms.TextBox();
            this.ArtID = new System.Windows.Forms.TextBox();
            this.ArtTitle = new System.Windows.Forms.TextBox();
            this.ArtAth = new System.Windows.Forms.TextBox();
            this.ArtPublisher = new System.Windows.Forms.TextBox();
            this.ArtQ = new System.Windows.Forms.TextBox();
            this.DOI = new System.Windows.Forms.TextBox();
            this.AddArticle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Bookidborrow = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.BorrowBook = new System.Windows.Forms.Button();
            this.Articleborrow = new System.Windows.Forms.Label();
            this.AIDBorrow = new System.Windows.Forms.TextBox();
            this.BorrowArticle = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ListofBooks = new System.Windows.Forms.ListBox();
            this.ListofArticles = new System.Windows.Forms.ListBox();
            this.ShowBook = new System.Windows.Forms.Button();
            this.ShowArt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Author:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Publisher:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "ISBN:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Genre:";
            // 
            // AddBook
            // 
            this.AddBook.Location = new System.Drawing.Point(28, 239);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(142, 23);
            this.AddBook.TabIndex = 7;
            this.AddBook.Text = "Add Study Book";
            this.AddBook.UseVisualStyleBackColor = true;
            this.AddBook.Click += new System.EventHandler(this.AddBook_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Article ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Title:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 351);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Author:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 381);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "Publisher:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 414);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "Quantity:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(37, 449);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 16);
            this.label13.TabIndex = 13;
            this.label13.Text = "DOI:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(266, 291);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 16);
            this.label14.TabIndex = 14;
            this.label14.Text = "Date:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(266, 319);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 16);
            this.label15.TabIndex = 15;
            this.label15.Text = "C/J:";
            // 
            // BID
            // 
            this.BID.Location = new System.Drawing.Point(119, 29);
            this.BID.Name = "BID";
            this.BID.Size = new System.Drawing.Size(100, 22);
            this.BID.TabIndex = 16;
            // 
            // BTitle
            // 
            this.BTitle.Location = new System.Drawing.Point(119, 60);
            this.BTitle.Name = "BTitle";
            this.BTitle.Size = new System.Drawing.Size(100, 22);
            this.BTitle.TabIndex = 17;
            // 
            // BAth
            // 
            this.BAth.Location = new System.Drawing.Point(119, 87);
            this.BAth.Name = "BAth";
            this.BAth.Size = new System.Drawing.Size(100, 22);
            this.BAth.TabIndex = 18;
            // 
            // BPublisher
            // 
            this.BPublisher.Location = new System.Drawing.Point(119, 119);
            this.BPublisher.Name = "BPublisher";
            this.BPublisher.Size = new System.Drawing.Size(100, 22);
            this.BPublisher.TabIndex = 19;
            // 
            // BQuantity
            // 
            this.BQuantity.Location = new System.Drawing.Point(119, 148);
            this.BQuantity.Name = "BQuantity";
            this.BQuantity.Size = new System.Drawing.Size(100, 22);
            this.BQuantity.TabIndex = 20;
            // 
            // ISBNtxtbox
            // 
            this.ISBNtxtbox.Location = new System.Drawing.Point(119, 176);
            this.ISBNtxtbox.Name = "ISBNtxtbox";
            this.ISBNtxtbox.Size = new System.Drawing.Size(100, 22);
            this.ISBNtxtbox.TabIndex = 21;
            // 
            // Genre
            // 
            this.Genre.Location = new System.Drawing.Point(119, 204);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(100, 22);
            this.Genre.TabIndex = 22;
            // 
            // Datetxtbox
            // 
            this.Datetxtbox.Location = new System.Drawing.Point(326, 288);
            this.Datetxtbox.Name = "Datetxtbox";
            this.Datetxtbox.Size = new System.Drawing.Size(100, 22);
            this.Datetxtbox.TabIndex = 23;
            // 
            // CJtxtbox
            // 
            this.CJtxtbox.Location = new System.Drawing.Point(326, 319);
            this.CJtxtbox.Name = "CJtxtbox";
            this.CJtxtbox.Size = new System.Drawing.Size(100, 22);
            this.CJtxtbox.TabIndex = 24;
            // 
            // ArtID
            // 
            this.ArtID.Location = new System.Drawing.Point(119, 291);
            this.ArtID.Name = "ArtID";
            this.ArtID.Size = new System.Drawing.Size(100, 22);
            this.ArtID.TabIndex = 25;
            // 
            // ArtTitle
            // 
            this.ArtTitle.Location = new System.Drawing.Point(119, 319);
            this.ArtTitle.Name = "ArtTitle";
            this.ArtTitle.Size = new System.Drawing.Size(100, 22);
            this.ArtTitle.TabIndex = 26;
            // 
            // ArtAth
            // 
            this.ArtAth.Location = new System.Drawing.Point(119, 351);
            this.ArtAth.Name = "ArtAth";
            this.ArtAth.Size = new System.Drawing.Size(100, 22);
            this.ArtAth.TabIndex = 27;
            // 
            // ArtPublisher
            // 
            this.ArtPublisher.Location = new System.Drawing.Point(119, 381);
            this.ArtPublisher.Name = "ArtPublisher";
            this.ArtPublisher.Size = new System.Drawing.Size(100, 22);
            this.ArtPublisher.TabIndex = 28;
            // 
            // ArtQ
            // 
            this.ArtQ.Location = new System.Drawing.Point(119, 414);
            this.ArtQ.Name = "ArtQ";
            this.ArtQ.Size = new System.Drawing.Size(100, 22);
            this.ArtQ.TabIndex = 29;
            // 
            // DOI
            // 
            this.DOI.Location = new System.Drawing.Point(119, 449);
            this.DOI.Name = "DOI";
            this.DOI.Size = new System.Drawing.Size(100, 22);
            this.DOI.TabIndex = 30;
            // 
            // AddArticle
            // 
            this.AddArticle.Location = new System.Drawing.Point(97, 489);
            this.AddArticle.Name = "AddArticle";
            this.AddArticle.Size = new System.Drawing.Size(184, 23);
            this.AddArticle.TabIndex = 31;
            this.AddArticle.Text = "Add Research Article";
            this.AddArticle.UseVisualStyleBackColor = true;
            this.AddArticle.Click += new System.EventHandler(this.AddArticle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(455, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(12, 468);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // Bookidborrow
            // 
            this.Bookidborrow.Location = new System.Drawing.Point(575, 38);
            this.Bookidborrow.Name = "Bookidborrow";
            this.Bookidborrow.Size = new System.Drawing.Size(100, 22);
            this.Bookidborrow.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(501, 38);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 16);
            this.label16.TabIndex = 34;
            this.label16.Text = "Book ID:";
            // 
            // BorrowBook
            // 
            this.BorrowBook.Location = new System.Drawing.Point(504, 83);
            this.BorrowBook.Name = "BorrowBook";
            this.BorrowBook.Size = new System.Drawing.Size(142, 23);
            this.BorrowBook.TabIndex = 35;
            this.BorrowBook.Text = "Borrow";
            this.BorrowBook.UseVisualStyleBackColor = true;
            this.BorrowBook.Click += new System.EventHandler(this.BorrowBook_Click);
            // 
            // Articleborrow
            // 
            this.Articleborrow.AutoSize = true;
            this.Articleborrow.Location = new System.Drawing.Point(501, 134);
            this.Articleborrow.Name = "Articleborrow";
            this.Articleborrow.Size = new System.Drawing.Size(63, 16);
            this.Articleborrow.TabIndex = 36;
            this.Articleborrow.Text = "Article ID:";
            // 
            // AIDBorrow
            // 
            this.AIDBorrow.Location = new System.Drawing.Point(575, 134);
            this.AIDBorrow.Name = "AIDBorrow";
            this.AIDBorrow.Size = new System.Drawing.Size(100, 22);
            this.AIDBorrow.TabIndex = 37;
            // 
            // BorrowArticle
            // 
            this.BorrowArticle.Location = new System.Drawing.Point(504, 185);
            this.BorrowArticle.Name = "BorrowArticle";
            this.BorrowArticle.Size = new System.Drawing.Size(142, 23);
            this.BorrowArticle.TabIndex = 38;
            this.BorrowArticle.Text = "Borrow";
            this.BorrowArticle.UseVisualStyleBackColor = true;
            this.BorrowArticle.Click += new System.EventHandler(this.BorrowArticle_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(714, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(12, 468);
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // ListofBooks
            // 
            this.ListofBooks.FormattingEnabled = true;
            this.ListofBooks.ItemHeight = 16;
            this.ListofBooks.Location = new System.Drawing.Point(732, 51);
            this.ListofBooks.Name = "ListofBooks";
            this.ListofBooks.Size = new System.Drawing.Size(618, 164);
            this.ListofBooks.TabIndex = 40;
            // 
            // ListofArticles
            // 
            this.ListofArticles.FormattingEnabled = true;
            this.ListofArticles.ItemHeight = 16;
            this.ListofArticles.Location = new System.Drawing.Point(732, 255);
            this.ListofArticles.Name = "ListofArticles";
            this.ListofArticles.Size = new System.Drawing.Size(618, 164);
            this.ListofArticles.TabIndex = 41;
            // 
            // ShowBook
            // 
            this.ShowBook.Location = new System.Drawing.Point(504, 272);
            this.ShowBook.Name = "ShowBook";
            this.ShowBook.Size = new System.Drawing.Size(142, 23);
            this.ShowBook.TabIndex = 42;
            this.ShowBook.Text = "Show Study Book";
            this.ShowBook.UseVisualStyleBackColor = true;
            this.ShowBook.Click += new System.EventHandler(this.ShowBook_Click);
            // 
            // ShowArt
            // 
            this.ShowArt.Location = new System.Drawing.Point(504, 344);
            this.ShowArt.Name = "ShowArt";
            this.ShowArt.Size = new System.Drawing.Size(142, 23);
            this.ShowArt.TabIndex = 43;
            this.ShowArt.Text = "Show Articles";
            this.ShowArt.UseVisualStyleBackColor = true;
            this.ShowArt.Click += new System.EventHandler(this.ShowArt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 584);
            this.Controls.Add(this.ShowArt);
            this.Controls.Add(this.ShowBook);
            this.Controls.Add(this.ListofArticles);
            this.Controls.Add(this.ListofBooks);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BorrowArticle);
            this.Controls.Add(this.AIDBorrow);
            this.Controls.Add(this.Articleborrow);
            this.Controls.Add(this.BorrowBook);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.Bookidborrow);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AddArticle);
            this.Controls.Add(this.DOI);
            this.Controls.Add(this.ArtQ);
            this.Controls.Add(this.ArtPublisher);
            this.Controls.Add(this.ArtAth);
            this.Controls.Add(this.ArtTitle);
            this.Controls.Add(this.ArtID);
            this.Controls.Add(this.CJtxtbox);
            this.Controls.Add(this.Datetxtbox);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.ISBNtxtbox);
            this.Controls.Add(this.BQuantity);
            this.Controls.Add(this.BPublisher);
            this.Controls.Add(this.BAth);
            this.Controls.Add(this.BTitle);
            this.Controls.Add(this.BID);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AddBook);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddBook;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox BID;
        private System.Windows.Forms.TextBox BTitle;
        private System.Windows.Forms.TextBox BAth;
        private System.Windows.Forms.TextBox BPublisher;
        private System.Windows.Forms.TextBox BQuantity;
        private System.Windows.Forms.TextBox ISBNtxtbox;
        private System.Windows.Forms.TextBox Genre;
        private System.Windows.Forms.TextBox Datetxtbox;
        private System.Windows.Forms.TextBox CJtxtbox;
        private System.Windows.Forms.TextBox ArtID;
        private System.Windows.Forms.TextBox ArtTitle;
        private System.Windows.Forms.TextBox ArtAth;
        private System.Windows.Forms.TextBox ArtPublisher;
        private System.Windows.Forms.TextBox ArtQ;
        private System.Windows.Forms.TextBox DOI;
        private System.Windows.Forms.Button AddArticle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Bookidborrow;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button BorrowBook;
        private System.Windows.Forms.Label Articleborrow;
        private System.Windows.Forms.TextBox AIDBorrow;
        private System.Windows.Forms.Button BorrowArticle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox ListofBooks;
        private System.Windows.Forms.ListBox ListofArticles;
        private System.Windows.Forms.Button ShowBook;
        private System.Windows.Forms.Button ShowArt;
    }
}

