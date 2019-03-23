namespace Chat_CODie
{
    partial class UserManagement
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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_family = new System.Windows.Forms.TextBox();
            this.grid_users = new System.Windows.Forms.DataGridView();
            this.cmb_position = new System.Windows.Forms.ComboBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_repeatpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_users)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Family;";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Position:";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(43, 363);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(154, 363);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 7;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(277, 363);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(144, 23);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(208, 20);
            this.txt_name.TabIndex = 0;
            // 
            // txt_family
            // 
            this.txt_family.Location = new System.Drawing.Point(144, 69);
            this.txt_family.Name = "txt_family";
            this.txt_family.Size = new System.Drawing.Size(208, 20);
            this.txt_family.TabIndex = 1;
            // 
            // grid_users
            // 
            this.grid_users.AllowUserToAddRows = false;
            this.grid_users.AllowUserToDeleteRows = false;
            this.grid_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_users.Location = new System.Drawing.Point(43, 430);
            this.grid_users.MultiSelect = false;
            this.grid_users.Name = "grid_users";
            this.grid_users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_users.Size = new System.Drawing.Size(853, 314);
            this.grid_users.TabIndex = 10;
            // 
            // cmb_position
            // 
            this.cmb_position.FormattingEnabled = true;
            this.cmb_position.Items.AddRange(new object[] {
            "Admin",
            "Secretary",
            "Employee"});
            this.cmb_position.Location = new System.Drawing.Point(144, 114);
            this.cmb_position.Name = "cmb_position";
            this.cmb_position.Size = new System.Drawing.Size(208, 21);
            this.cmb_position.TabIndex = 2;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(386, 363);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(116, 23);
            this.btn_refresh.TabIndex = 9;
            this.btn_refresh.Text = "Refresh Table";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(144, 165);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(208, 20);
            this.txt_username.TabIndex = 3;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(144, 210);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(208, 20);
            this.txt_password.TabIndex = 4;
            // 
            // txt_repeatpassword
            // 
            this.txt_repeatpassword.Location = new System.Drawing.Point(144, 252);
            this.txt_repeatpassword.Name = "txt_repeatpassword";
            this.txt_repeatpassword.Size = new System.Drawing.Size(208, 20);
            this.txt_repeatpassword.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "User Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Repeat Password:";
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 766);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_repeatpassword);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.cmb_position);
            this.Controls.Add(this.grid_users);
            this.Controls.Add(this.txt_family);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserManagement";
            this.Text = "UserManagement";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserManagement_FormClosed);
            this.Load += new System.EventHandler(this.UserManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_family;
        private System.Windows.Forms.ComboBox cmb_position;
        public System.Windows.Forms.DataGridView grid_users;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_repeatpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}