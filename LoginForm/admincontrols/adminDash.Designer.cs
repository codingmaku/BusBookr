namespace LoginForm.admincontrols
{
    partial class adminDash
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.overallRev = new System.Windows.Forms.Label();
            this.revToday = new System.Windows.Forms.Label();
            this.pendingReq = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.avaiableBus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(150, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 47);
            this.label1.TabIndex = 23;
            this.label1.Text = "ADMIN DASHBOARD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(407, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 28);
            this.label3.TabIndex = 135;
            this.label3.Text = "Pending Requests";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(39, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 28);
            this.label9.TabIndex = 134;
            this.label9.Text = "Available Buses";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(407, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 28);
            this.label8.TabIndex = 133;
            this.label8.Text = "Overall Revenue";
            // 
            // overallRev
            // 
            this.overallRev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.overallRev.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.overallRev.Location = new System.Drawing.Point(412, 402);
            this.overallRev.Name = "overallRev";
            this.overallRev.Size = new System.Drawing.Size(300, 177);
            this.overallRev.TabIndex = 132;
            // 
            // revToday
            // 
            this.revToday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.revToday.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.revToday.Location = new System.Drawing.Point(44, 402);
            this.revToday.Name = "revToday";
            this.revToday.Size = new System.Drawing.Size(300, 177);
            this.revToday.TabIndex = 131;
            // 
            // pendingReq
            // 
            this.pendingReq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pendingReq.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pendingReq.Location = new System.Drawing.Point(412, 150);
            this.pendingReq.Name = "pendingReq";
            this.pendingReq.Size = new System.Drawing.Size(300, 177);
            this.pendingReq.TabIndex = 130;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(39, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 28);
            this.label5.TabIndex = 128;
            this.label5.Text = "Revenue Today";
            // 
            // avaiableBus
            // 
            this.avaiableBus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avaiableBus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.avaiableBus.Location = new System.Drawing.Point(44, 150);
            this.avaiableBus.Name = "avaiableBus";
            this.avaiableBus.Size = new System.Drawing.Size(300, 177);
            this.avaiableBus.TabIndex = 129;
            // 
            // adminDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.overallRev);
            this.Controls.Add(this.revToday);
            this.Controls.Add(this.pendingReq);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.avaiableBus);
            this.Controls.Add(this.label1);
            this.Name = "adminDash";
            this.Size = new System.Drawing.Size(750, 700);
            this.Load += new System.EventHandler(this.adminDash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label overallRev;
        private System.Windows.Forms.Label revToday;
        private System.Windows.Forms.Label pendingReq;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label avaiableBus;
    }
}
