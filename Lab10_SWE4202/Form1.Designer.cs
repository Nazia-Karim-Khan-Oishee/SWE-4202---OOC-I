namespace Lab10_SWE4202
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
            this.listofusers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Searchforemail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ShowUser = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.firstname_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zip_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone1_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone2_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listofusers
            // 
            this.listofusers.FormattingEnabled = true;
            this.listofusers.ItemHeight = 16;
            this.listofusers.Location = new System.Drawing.Point(3, 11);
            this.listofusers.Name = "listofusers";
            this.listofusers.Size = new System.Drawing.Size(795, 500);
            this.listofusers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1567, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "E-mail:";
            // 
            // Searchforemail
            // 
            this.Searchforemail.Location = new System.Drawing.Point(1469, 95);
            this.Searchforemail.Name = "Searchforemail";
            this.Searchforemail.Size = new System.Drawing.Size(252, 22);
            this.Searchforemail.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1508, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShowUser
            // 
            this.ShowUser.FormattingEnabled = true;
            this.ShowUser.ItemHeight = 16;
            this.ShowUser.Location = new System.Drawing.Point(1347, 221);
            this.ShowUser.Name = "ShowUser";
            this.ShowUser.Size = new System.Drawing.Size(482, 228);
            this.ShowUser.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstname_col,
            this.Lastname,
            this.Address_col,
            this.City_col,
            this.Country_col,
            this.State_col,
            this.Zip_col,
            this.Phone1_col,
            this.Phone2_col,
            this.email_col});
            this.dataGridView1.Location = new System.Drawing.Point(4, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1301, 530);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // firstname_col
            // 
            this.firstname_col.HeaderText = "First Name";
            this.firstname_col.MinimumWidth = 6;
            this.firstname_col.Name = "firstname_col";
            this.firstname_col.ReadOnly = true;
            this.firstname_col.Width = 125;
            // 
            // Lastname
            // 
            this.Lastname.HeaderText = "Last Name";
            this.Lastname.MinimumWidth = 6;
            this.Lastname.Name = "Lastname";
            this.Lastname.ReadOnly = true;
            this.Lastname.Width = 125;
            // 
            // Address_col
            // 
            this.Address_col.HeaderText = "Address";
            this.Address_col.MinimumWidth = 6;
            this.Address_col.Name = "Address_col";
            this.Address_col.ReadOnly = true;
            this.Address_col.Width = 125;
            // 
            // City_col
            // 
            this.City_col.HeaderText = "City";
            this.City_col.MinimumWidth = 6;
            this.City_col.Name = "City_col";
            this.City_col.ReadOnly = true;
            this.City_col.Width = 125;
            // 
            // Country_col
            // 
            this.Country_col.HeaderText = "Country";
            this.Country_col.MinimumWidth = 6;
            this.Country_col.Name = "Country_col";
            this.Country_col.ReadOnly = true;
            this.Country_col.Width = 125;
            // 
            // State_col
            // 
            this.State_col.HeaderText = "State";
            this.State_col.MinimumWidth = 6;
            this.State_col.Name = "State_col";
            this.State_col.ReadOnly = true;
            this.State_col.Width = 125;
            // 
            // Zip_col
            // 
            this.Zip_col.HeaderText = "Zip";
            this.Zip_col.MinimumWidth = 6;
            this.Zip_col.Name = "Zip_col";
            this.Zip_col.ReadOnly = true;
            this.Zip_col.Width = 125;
            // 
            // Phone1_col
            // 
            this.Phone1_col.HeaderText = "Phone1";
            this.Phone1_col.MinimumWidth = 6;
            this.Phone1_col.Name = "Phone1_col";
            this.Phone1_col.ReadOnly = true;
            this.Phone1_col.Width = 125;
            // 
            // Phone2_col
            // 
            this.Phone2_col.HeaderText = "Phone2";
            this.Phone2_col.MinimumWidth = 6;
            this.Phone2_col.Name = "Phone2_col";
            this.Phone2_col.ReadOnly = true;
            this.Phone2_col.Width = 125;
            // 
            // email_col
            // 
            this.email_col.HeaderText = "E-mail";
            this.email_col.MinimumWidth = 6;
            this.email_col.Name = "email_col";
            this.email_col.ReadOnly = true;
            this.email_col.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1860, 527);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ShowUser);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Searchforemail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listofusers);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listofusers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Searchforemail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox ShowUser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn City_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn State_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zip_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone1_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone2_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_col;
    }
}

