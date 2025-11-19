namespace LoginForm.admincontrols
{
    partial class viewBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewBooking));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.ComboBox();
            this.departureTime = new System.Windows.Forms.Label();
            this.departureDate = new System.Windows.Forms.Label();
            this.destination = new System.Windows.Forms.Label();
            this.busType = new System.Windows.Forms.Label();
            this.contactNum = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fullName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Controls.Add(this.status);
            this.panel1.Controls.Add(this.departureTime);
            this.panel1.Controls.Add(this.departureDate);
            this.panel1.Controls.Add(this.destination);
            this.panel1.Controls.Add(this.busType);
            this.panel1.Controls.Add(this.contactNum);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.fullName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 700);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Gainsboro;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnReturn.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnReturn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnReturn.Location = new System.Drawing.Point(65, 535);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(197, 44);
            this.btnReturn.TabIndex = 130;
            this.btnReturn.Text = "RETURN";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click_1);
            // 
            // status
            // 
            this.status.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.DimGray;
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "Verified",
            "Pending",
            "Rejected"});
            this.status.Location = new System.Drawing.Point(515, 541);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(197, 31);
            this.status.TabIndex = 129;
            this.status.Text = "Pending";
            // 
            // departureTime
            // 
            this.departureTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.departureTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.departureTime.Location = new System.Drawing.Point(391, 463);
            this.departureTime.Name = "departureTime";
            this.departureTime.Size = new System.Drawing.Size(328, 31);
            this.departureTime.TabIndex = 128;
            // 
            // departureDate
            // 
            this.departureDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.departureDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.departureDate.Location = new System.Drawing.Point(31, 466);
            this.departureDate.Name = "departureDate";
            this.departureDate.Size = new System.Drawing.Size(328, 31);
            this.departureDate.TabIndex = 127;
            // 
            // destination
            // 
            this.destination.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.destination.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.destination.Location = new System.Drawing.Point(391, 379);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(328, 31);
            this.destination.TabIndex = 126;
            // 
            // busType
            // 
            this.busType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.busType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.busType.Location = new System.Drawing.Point(31, 379);
            this.busType.Name = "busType";
            this.busType.Size = new System.Drawing.Size(328, 31);
            this.busType.TabIndex = 125;
            // 
            // contactNum
            // 
            this.contactNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactNum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.contactNum.Location = new System.Drawing.Point(31, 296);
            this.contactNum.Name = "contactNum";
            this.contactNum.Size = new System.Drawing.Size(328, 31);
            this.contactNum.TabIndex = 124;
            // 
            // email
            // 
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.email.Location = new System.Drawing.Point(31, 210);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(328, 31);
            this.email.TabIndex = 123;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Gainsboro;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirm.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnConfirm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnConfirm.Location = new System.Drawing.Point(293, 535);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(197, 44);
            this.btnConfirm.TabIndex = 122;
            this.btnConfirm.Text = "CONFIRM";
            this.btnConfirm.UseVisualStyleBackColor = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(386, 435);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(162, 28);
            this.label18.TabIndex = 121;
            this.label18.Text = "Departure Time";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(26, 438);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(160, 28);
            this.label16.TabIndex = 120;
            this.label16.Text = "Departure Date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(511, 302);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 28);
            this.label13.TabIndex = 118;
            this.label13.Text = "Hachimi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(388, 351);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 28);
            this.label11.TabIndex = 116;
            this.label11.Text = "Destination";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 351);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 28);
            this.label9.TabIndex = 115;
            this.label9.Text = "Type of Bus";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 268);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 28);
            this.label7.TabIndex = 114;
            this.label7.Text = "Contact Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 28);
            this.label5.TabIndex = 113;
            this.label5.Text = "Email";
            // 
            // fullName
            // 
            this.fullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fullName.Location = new System.Drawing.Point(31, 128);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(328, 31);
            this.fullName.TabIndex = 112;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 28);
            this.label1.TabIndex = 111;
            this.label1.Text = "Full Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(461, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 110;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(396, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 47);
            this.label2.TabIndex = 109;
            this.label2.Text = "BUS BOOKR";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(689, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 108;
            this.pictureBox2.TabStop = false;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label12.Location = new System.Drawing.Point(450, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(211, 192);
            this.label12.TabIndex = 117;
            // 
            // viewBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "viewBooking";
            this.Size = new System.Drawing.Size(750, 700);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.Label departureTime;
        private System.Windows.Forms.Label departureDate;
        private System.Windows.Forms.Label destination;
        private System.Windows.Forms.Label busType;
        private System.Windows.Forms.Label contactNum;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label fullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label12;
    }
}
