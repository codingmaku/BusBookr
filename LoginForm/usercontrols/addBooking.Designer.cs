namespace LoginForm.usercontrols
{
    partial class addBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addBooking));
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.typeofbus_user = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.destination_user = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.departureDate_user = new System.Windows.Forms.DateTimePicker();
            this.returnDate_user = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBookNow = new System.Windows.Forms.Button();
            this.btnViewBus = new System.Windows.Forms.Button();
            this.price_user = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.phoneNumber_user = new System.Windows.Forms.Label();
            this.email_user = new System.Windows.Forms.Label();
            this.fullName_user = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 31);
            this.label5.TabIndex = 53;
            this.label5.Text = "Add Booking";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(203, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 47);
            this.label2.TabIndex = 55;
            this.label2.Text = "BUS BOOKR";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(484, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 28);
            this.label1.TabIndex = 76;
            this.label1.Text = "Full Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(277, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 28);
            this.label4.TabIndex = 83;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 28);
            this.label3.TabIndex = 80;
            this.label3.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 227);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 28);
            this.label8.TabIndex = 90;
            this.label8.Text = "Type of Bus";
            // 
            // typeofbus_user
            // 
            this.typeofbus_user.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeofbus_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.typeofbus_user.FormattingEnabled = true;
            this.typeofbus_user.Items.AddRange(new object[] {
            "Coaster Bus",
            "Tourist Bus"});
            this.typeofbus_user.Location = new System.Drawing.Point(8, 258);
            this.typeofbus_user.Name = "typeofbus_user";
            this.typeofbus_user.Size = new System.Drawing.Size(261, 31);
            this.typeofbus_user.TabIndex = 89;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(277, 157);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 28);
            this.label9.TabIndex = 92;
            this.label9.Text = "Select Destination";
            // 
            // destination_user
            // 
            this.destination_user.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destination_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.destination_user.FormattingEnabled = true;
            this.destination_user.Items.AddRange(new object[] {
            "Bacoor",
            "Kawit",
            "Noveleta",
            "Rosario",
            "General Trias",
            "Tanza",
            "Naic",
            "Indang",
            "Maragondon"});
            this.destination_user.Location = new System.Drawing.Point(282, 188);
            this.destination_user.Name = "destination_user";
            this.destination_user.Size = new System.Drawing.Size(260, 31);
            this.destination_user.TabIndex = 91;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 303);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 28);
            this.label6.TabIndex = 94;
            this.label6.Text = "Departure Date";
            // 
            // departureDate_user
            // 
            this.departureDate_user.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.departureDate_user.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.departureDate_user.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.departureDate_user.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departureDate_user.Location = new System.Drawing.Point(8, 335);
            this.departureDate_user.Margin = new System.Windows.Forms.Padding(4);
            this.departureDate_user.Name = "departureDate_user";
            this.departureDate_user.Size = new System.Drawing.Size(534, 30);
            this.departureDate_user.TabIndex = 93;
            // 
            // returnDate_user
            // 
            this.returnDate_user.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.returnDate_user.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.returnDate_user.CalendarTrailingForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.returnDate_user.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnDate_user.Location = new System.Drawing.Point(8, 413);
            this.returnDate_user.Margin = new System.Windows.Forms.Padding(4);
            this.returnDate_user.Name = "returnDate_user";
            this.returnDate_user.Size = new System.Drawing.Size(534, 30);
            this.returnDate_user.TabIndex = 96;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 381);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 28);
            this.label7.TabIndex = 95;
            this.label7.Text = "Return Date";
            // 
            // btnBookNow
            // 
            this.btnBookNow.BackColor = System.Drawing.Color.Gainsboro;
            this.btnBookNow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookNow.FlatAppearance.BorderSize = 0;
            this.btnBookNow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBookNow.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnBookNow.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnBookNow.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBookNow.Location = new System.Drawing.Point(282, 451);
            this.btnBookNow.Margin = new System.Windows.Forms.Padding(4);
            this.btnBookNow.Name = "btnBookNow";
            this.btnBookNow.Size = new System.Drawing.Size(260, 50);
            this.btnBookNow.TabIndex = 98;
            this.btnBookNow.Text = "BOOK NOW";
            this.btnBookNow.UseVisualStyleBackColor = false;
            this.btnBookNow.Click += new System.EventHandler(this.btnBookNow_Click);
            // 
            // btnViewBus
            // 
            this.btnViewBus.BackColor = System.Drawing.Color.Gainsboro;
            this.btnViewBus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewBus.FlatAppearance.BorderSize = 0;
            this.btnViewBus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewBus.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnViewBus.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnViewBus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnViewBus.Location = new System.Drawing.Point(9, 451);
            this.btnViewBus.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewBus.Name = "btnViewBus";
            this.btnViewBus.Size = new System.Drawing.Size(260, 50);
            this.btnViewBus.TabIndex = 97;
            this.btnViewBus.Text = "VIEW BUS AND DESTINATION";
            this.btnViewBus.UseVisualStyleBackColor = false;
            this.btnViewBus.Click += new System.EventHandler(this.btnViewBus_Click);
            // 
            // price_user
            // 
            this.price_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.price_user.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.price_user.Location = new System.Drawing.Point(282, 258);
            this.price_user.Name = "price_user";
            this.price_user.Size = new System.Drawing.Size(260, 31);
            this.price_user.TabIndex = 117;
            this.price_user.Text = "67";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(277, 230);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 28);
            this.label14.TabIndex = 116;
            this.label14.Text = "Price";
            // 
            // phoneNumber_user
            // 
            this.phoneNumber_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneNumber_user.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.phoneNumber_user.Location = new System.Drawing.Point(282, 101);
            this.phoneNumber_user.Name = "phoneNumber_user";
            this.phoneNumber_user.Size = new System.Drawing.Size(260, 31);
            this.phoneNumber_user.TabIndex = 115;
            this.phoneNumber_user.Text = "0912345679";
            // 
            // email_user
            // 
            this.email_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email_user.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.email_user.Location = new System.Drawing.Point(9, 188);
            this.email_user.Name = "email_user";
            this.email_user.Size = new System.Drawing.Size(260, 31);
            this.email_user.TabIndex = 113;
            this.email_user.Text = "niggaboigreat@gmail.com";
            // 
            // fullName_user
            // 
            this.fullName_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullName_user.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fullName_user.Location = new System.Drawing.Point(9, 101);
            this.fullName_user.Name = "fullName_user";
            this.fullName_user.Size = new System.Drawing.Size(260, 31);
            this.fullName_user.TabIndex = 114;
            this.fullName_user.Text = "nigga boi super ";
            // 
            // addBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.price_user);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.phoneNumber_user);
            this.Controls.Add(this.fullName_user);
            this.Controls.Add(this.email_user);
            this.Controls.Add(this.btnBookNow);
            this.Controls.Add(this.btnViewBus);
            this.Controls.Add(this.returnDate_user);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.departureDate_user);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.destination_user);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.typeofbus_user);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Name = "addBooking";
            this.Size = new System.Drawing.Size(550, 600);
            this.Load += new System.EventHandler(this.userBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox typeofbus_user;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox destination_user;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker departureDate_user;
        private System.Windows.Forms.DateTimePicker returnDate_user;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBookNow;
        private System.Windows.Forms.Button btnViewBus;
        private System.Windows.Forms.Label price_user;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label phoneNumber_user;
        private System.Windows.Forms.Label email_user;
        private System.Windows.Forms.Label fullName_user;
    }
}
