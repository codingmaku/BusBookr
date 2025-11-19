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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roles_admin = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.status_admin = new System.Windows.Forms.ComboBox();
            this.btnAddAdmin = new System.Windows.Forms.Button();
            this.fullName_admin = new System.Windows.Forms.TextBox();
            this.email_admin = new System.Windows.Forms.TextBox();
            this.password_admin = new System.Windows.Forms.TextBox();
            this.confirmPass_admin = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(200, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(360, 47);
            this.label5.TabIndex = 134;
            this.label5.Text = "MANAGE ADMIN";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(27, 385);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 254);
            this.panel2.TabIndex = 135;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(700, 254);
            this.dataGridView1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(22, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 28);
            this.label3.TabIndex = 137;
            this.label3.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(394, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 28);
            this.label2.TabIndex = 139;
            this.label2.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(22, 237);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 28);
            this.label11.TabIndex = 146;
            this.label11.Text = "Confirm Password";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.confirmPass_admin);
            this.panel1.Controls.Add(this.password_admin);
            this.panel1.Controls.Add(this.email_admin);
            this.panel1.Controls.Add(this.fullName_admin);
            this.panel1.Controls.Add(this.btnAddAdmin);
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 700);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // roles_admin
            // 
            this.roles_admin.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roles_admin.ForeColor = System.Drawing.Color.DimGray;
            this.roles_admin.FormattingEnabled = true;
            this.roles_admin.Items.AddRange(new object[] {
            "Admin",
            "Super Admin"});
            this.roles_admin.Location = new System.Drawing.Point(399, 182);
            this.roles_admin.Name = "roles_admin";
            this.roles_admin.Size = new System.Drawing.Size(328, 31);
            this.roles_admin.TabIndex = 152;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(394, 156);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 28);
            this.label12.TabIndex = 153;
            this.label12.Text = "Roles";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(22, 156);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 28);
            this.label6.TabIndex = 141;
            this.label6.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(394, 234);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 28);
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
            this.status_admin.Location = new System.Drawing.Point(399, 265);
            this.status_admin.Name = "status_admin";
            this.status_admin.Size = new System.Drawing.Size(328, 31);
            this.status_admin.TabIndex = 154;
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
            this.btnAddAdmin.Location = new System.Drawing.Point(530, 314);
            this.btnAddAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(197, 50);
            this.btnAddAdmin.TabIndex = 159;
            this.btnAddAdmin.Text = "ADD AS ADMIN";
            this.btnAddAdmin.UseVisualStyleBackColor = false;
            this.btnAddAdmin.Click += new System.EventHandler(this.btnAddAdmin_Click);
            // 
            // fullName_admin
            // 
            this.fullName_admin.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullName_admin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.fullName_admin.Location = new System.Drawing.Point(27, 111);
            this.fullName_admin.Margin = new System.Windows.Forms.Padding(4);
            this.fullName_admin.Name = "fullName_admin";
            this.fullName_admin.Size = new System.Drawing.Size(328, 31);
            this.fullName_admin.TabIndex = 160;
            // 
            // email_admin
            // 
            this.email_admin.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_admin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.email_admin.Location = new System.Drawing.Point(399, 111);
            this.email_admin.Margin = new System.Windows.Forms.Padding(4);
            this.email_admin.Name = "email_admin";
            this.email_admin.Size = new System.Drawing.Size(328, 31);
            this.email_admin.TabIndex = 161;
            // 
            // password_admin
            // 
            this.password_admin.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_admin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.password_admin.Location = new System.Drawing.Point(27, 182);
            this.password_admin.Margin = new System.Windows.Forms.Padding(4);
            this.password_admin.Name = "password_admin";
            this.password_admin.Size = new System.Drawing.Size(328, 31);
            this.password_admin.TabIndex = 162;
            // 
            // confirmPass_admin
            // 
            this.confirmPass_admin.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPass_admin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.confirmPass_admin.Location = new System.Drawing.Point(27, 269);
            this.confirmPass_admin.Margin = new System.Windows.Forms.Padding(4);
            this.confirmPass_admin.Name = "confirmPass_admin";
            this.confirmPass_admin.Size = new System.Drawing.Size(328, 31);
            this.confirmPass_admin.TabIndex = 163;
            // 
            // manageAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "manageAdmin";
            this.Size = new System.Drawing.Size(750, 700);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
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
    }
}
