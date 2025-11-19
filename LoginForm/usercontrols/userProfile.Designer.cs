namespace LoginForm.usercontrols
{
    partial class userProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userProfile));
            this.fullName_user = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.email_user = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.phoneNumber_user = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fullName_user
            // 
            this.fullName_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullName_user.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fullName_user.Location = new System.Drawing.Point(7, 158);
            this.fullName_user.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fullName_user.Name = "fullName_user";
            this.fullName_user.Size = new System.Drawing.Size(330, 30);
            this.fullName_user.TabIndex = 120;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(7, 48);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 118;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(2, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 25);
            this.label5.TabIndex = 121;
            this.label5.Text = "Your Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 123;
            this.label3.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 125;
            this.label2.Text = "Email";
            // 
            // email_user
            // 
            this.email_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email_user.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.email_user.Location = new System.Drawing.Point(7, 234);
            this.email_user.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.email_user.Name = "email_user";
            this.email_user.Size = new System.Drawing.Size(330, 30);
            this.email_user.TabIndex = 124;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 21);
            this.label6.TabIndex = 127;
            this.label6.Text = "Phone Number";
            // 
            // phoneNumber_user
            // 
            this.phoneNumber_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneNumber_user.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.phoneNumber_user.Location = new System.Drawing.Point(7, 311);
            this.phoneNumber_user.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneNumber_user.Name = "phoneNumber_user";
            this.phoneNumber_user.Size = new System.Drawing.Size(330, 30);
            this.phoneNumber_user.TabIndex = 126;
            // 
            // userProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.phoneNumber_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.email_user);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fullName_user);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "userProfile";
            this.Size = new System.Drawing.Size(412, 488);
            this.Load += new System.EventHandler(this.userProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fullName_user;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label email_user;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label phoneNumber_user;
    }
}
