namespace LoginForm.admincontrols
{
    partial class manageAdmin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.admin_table = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.confirmPass_admin = new System.Windows.Forms.TextBox();
            this.password_admin = new System.Windows.Forms.TextBox();
            this.email_admin = new System.Windows.Forms.TextBox();
            this.fullName_admin = new System.Windows.Forms.TextBox();
            this.btnAddAdmin = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.status_admin = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.roles_admin = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.update_button = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admin_table)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(150, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(291, 38);
            this.label5.TabIndex = 134;
            this.label5.Text = "MANAGE ADMIN";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.admin_table);
            this.panel2.Location = new System.Drawing.Point(20, 313);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(525, 206);
            this.panel2.TabIndex = 135;
            // 
            // admin_table
            // 
            this.admin_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.admin_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.admin_table.Location = new System.Drawing.Point(0, 0);
            this.admin_table.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.admin_table.Name = "admin_table";
            this.admin_table.RowHeadersWidth = 51;
            this.admin_table.RowTemplate.Height = 24;
            this.admin_table.Size = new System.Drawing.Size(525, 206);
            this.admin_table.TabIndex = 0;
            this.admin_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.admin_table_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 137;
            this.label3.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(296, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 139;
            this.label2.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(16, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 21);
            this.label11.TabIndex = 146;
            this.label11.Text = "Confirm Password";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.confirmPass_admin);
            this.panel1.Controls.Add(this.password_admin);
            this.panel1.Controls.Add(this.email_admin);
            this.panel1.Controls.Add(this.fullName_admin);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.status_admin);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.roles_admin);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnAddAdmin);
            this.panel1.Controls.Add(this.update_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 569);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // confirmPass_admin
            // 
            this.confirmPass_admin.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPass_admin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.confirmPass_admin.Location = new System.Drawing.Point(20, 219);
            this.confirmPass_admin.Name = "confirmPass_admin";
            this.confirmPass_admin.Size = new System.Drawing.Size(247, 27);
            this.confirmPass_admin.TabIndex = 163;
            // 
            // password_admin
            // 
            this.password_admin.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_admin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.password_admin.Location = new System.Drawing.Point(20, 148);
            this.password_admin.Name = "password_admin";
            this.password_admin.Size = new System.Drawing.Size(247, 27);
            this.password_admin.TabIndex = 162;
            // 
            // email_admin
            // 
            this.email_admin.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_admin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.email_admin.Location = new System.Drawing.Point(299, 90);
            this.email_admin.Name = "email_admin";
            this.email_admin.Size = new System.Drawing.Size(247, 27);
            this.email_admin.TabIndex = 161;
            // 
            // fullName_admin
            // 
            this.fullName_admin.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullName_admin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.fullName_admin.Location = new System.Drawing.Point(20, 90);
            this.fullName_admin.Name = "fullName_admin";
            this.fullName_admin.Size = new System.Drawing.Size(247, 27);
            this.fullName_admin.TabIndex = 160;
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAdmin.FlatAppearance.BorderSize = 0;
            this.btnAddAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddAdmin.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAddAdmin.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnAddAdmin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddAdmin.Location = new System.Drawing.Point(398, 255);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(148, 41);
            this.btnAddAdmin.TabIndex = 159;
            this.btnAddAdmin.Text = "ADD AS ADMIN";
            this.btnAddAdmin.UseVisualStyleBackColor = false;
            this.btnAddAdmin.Click += new System.EventHandler(this.btnAddAdmin_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(296, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 21);
            this.label8.TabIndex = 155;
            this.label8.Text = "Status";
            // 
            // status_admin
            // 
            this.status_admin.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_admin.ForeColor = System.Drawing.Color.DimGray;
            this.status_admin.FormattingEnabled = true;
            this.status_admin.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.status_admin.Location = new System.Drawing.Point(299, 215);
            this.status_admin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.status_admin.Name = "status_admin";
            this.status_admin.Size = new System.Drawing.Size(247, 27);
            this.status_admin.TabIndex = 154;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(296, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 21);
            this.label12.TabIndex = 153;
            this.label12.Text = "Roles";
            // 
            // roles_admin
            // 
            this.roles_admin.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roles_admin.ForeColor = System.Drawing.Color.DimGray;
            this.roles_admin.FormattingEnabled = true;
            this.roles_admin.Items.AddRange(new object[] {
            "Admin",
            "Super Admin"});
            this.roles_admin.Location = new System.Drawing.Point(299, 148);
            this.roles_admin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roles_admin.Name = "roles_admin";
            this.roles_admin.Size = new System.Drawing.Size(247, 27);
            this.roles_admin.TabIndex = 152;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(16, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 21);
            this.label6.TabIndex = 141;
            this.label6.Text = "Password";
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.Transparent;
            this.update_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_button.FlatAppearance.BorderSize = 0;
            this.update_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.update_button.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.update_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.update_button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.update_button.Location = new System.Drawing.Point(397, 255);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(148, 41);
            this.update_button.TabIndex = 164;
            this.update_button.Text = "UPDATE ";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // manageAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "manageAdmin";
            this.Size = new System.Drawing.Size(562, 569);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.admin_table)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView admin_table;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox roles_admin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox status_admin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddAdmin;
        private System.Windows.Forms.TextBox confirmPass_admin;
        private System.Windows.Forms.TextBox password_admin;
        private System.Windows.Forms.TextBox email_admin;
        private System.Windows.Forms.TextBox fullName_admin;
        private System.Windows.Forms.Button update_button;
    }
}
