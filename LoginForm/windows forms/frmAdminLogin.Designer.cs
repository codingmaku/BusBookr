namespace LoginForm
{
    partial class frmAdminLogin
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdminClear = new System.Windows.Forms.Button();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.cbShowPass = new System.Windows.Forms.CheckBox();
            this.adminpass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.adminemail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblReturn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(159, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 38);
            this.label4.TabIndex = 80;
            this.label4.Text = "Admin Login";
            // 
            // btnAdminClear
            // 
            this.btnAdminClear.BackColor = System.Drawing.Color.White;
            this.btnAdminClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminClear.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnAdminClear.Location = new System.Drawing.Point(20, 392);
            this.btnAdminClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdminClear.Name = "btnAdminClear";
            this.btnAdminClear.Size = new System.Drawing.Size(326, 50);
            this.btnAdminClear.TabIndex = 77;
            this.btnAdminClear.Text = "CLEAR";
            this.btnAdminClear.UseVisualStyleBackColor = false;
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.BackColor = System.Drawing.Color.OrangeRed;
            this.btnAdminLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminLogin.FlatAppearance.BorderSize = 0;
            this.btnAdminLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminLogin.ForeColor = System.Drawing.Color.White;
            this.btnAdminLogin.Location = new System.Drawing.Point(20, 323);
            this.btnAdminLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(326, 50);
            this.btnAdminLogin.TabIndex = 76;
            this.btnAdminLogin.Text = "LOGIN";
            this.btnAdminLogin.UseVisualStyleBackColor = false;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // cbShowPass
            // 
            this.cbShowPass.AutoSize = true;
            this.cbShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbShowPass.Location = new System.Drawing.Point(178, 282);
            this.cbShowPass.Margin = new System.Windows.Forms.Padding(4);
            this.cbShowPass.Name = "cbShowPass";
            this.cbShowPass.Size = new System.Drawing.Size(151, 27);
            this.cbShowPass.TabIndex = 75;
            this.cbShowPass.Text = "Show Password";
            this.cbShowPass.UseVisualStyleBackColor = true;
            // 
            // adminpass
            // 
            this.adminpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.adminpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adminpass.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminpass.Location = new System.Drawing.Point(19, 230);
            this.adminpass.Margin = new System.Windows.Forms.Padding(4);
            this.adminpass.Multiline = true;
            this.adminpass.Name = "adminpass";
            this.adminpass.Size = new System.Drawing.Size(326, 40);
            this.adminpass.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 73;
            this.label3.Text = "Password";
            // 
            // adminemail
            // 
            this.adminemail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.adminemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adminemail.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminemail.Location = new System.Drawing.Point(20, 137);
            this.adminemail.Margin = new System.Windows.Forms.Padding(4);
            this.adminemail.Multiline = true;
            this.adminemail.Name = "adminemail";
            this.adminemail.Size = new System.Drawing.Size(326, 40);
            this.adminemail.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 71;
            this.label2.Text = "E-Mail";
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReturn.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lblReturn.Location = new System.Drawing.Point(10, 7);
            this.lblReturn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(51, 54);
            this.lblReturn.TabIndex = 81;
            this.lblReturn.Text = "<";
            this.lblReturn.Click += new System.EventHandler(this.lblReturn_Click);
            // 
            // frmAdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(365, 575);
            this.Controls.Add(this.lblReturn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAdminClear);
            this.Controls.Add(this.btnAdminLogin);
            this.Controls.Add(this.cbShowPass);
            this.Controls.Add(this.adminpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adminemail);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdminLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdminClear;
        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.CheckBox cbShowPass;
        private System.Windows.Forms.TextBox adminpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adminemail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblReturn;
    }
}