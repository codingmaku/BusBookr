namespace LoginForm.admincontrols
{
    partial class manageBooking
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
            this.panel = new System.Windows.Forms.Panel();
            this.btnViewPend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.manageBooks = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manageBooks)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.panel1);
            this.panel.Controls.Add(this.btnViewPend);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.comboBox1);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.textBox1);
            this.panel.Controls.Add(this.label3);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(750, 700);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // btnViewPend
            // 
            this.btnViewPend.BackColor = System.Drawing.Color.Gainsboro;
            this.btnViewPend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewPend.FlatAppearance.BorderSize = 0;
            this.btnViewPend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewPend.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnViewPend.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnViewPend.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnViewPend.Location = new System.Drawing.Point(247, 628);
            this.btnViewPend.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewPend.Name = "btnViewPend";
            this.btnViewPend.Size = new System.Drawing.Size(267, 46);
            this.btnViewPend.TabIndex = 100;
            this.btnViewPend.Text = "VIEW PENDING BOOKINGS";
            this.btnViewPend.UseVisualStyleBackColor = false;
            this.btnViewPend.Click += new System.EventHandler(this.btnViewPend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(162, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 47);
            this.label1.TabIndex = 34;
            this.label1.Text = "MANAGE BOOKING";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // manageBooks
            // 
            this.manageBooks.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.manageBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.manageBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manageBooks.Location = new System.Drawing.Point(0, 0);
            this.manageBooks.Name = "manageBooks";
            this.manageBooks.RowHeadersWidth = 51;
            this.manageBooks.RowTemplate.Height = 24;
            this.manageBooks.Size = new System.Drawing.Size(707, 461);
            this.manageBooks.TabIndex = 40;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Verified",
            "Pending",
            "Rejected"});
            this.comboBox1.Location = new System.Drawing.Point(551, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 24);
            this.comboBox1.TabIndex = 38;
            this.comboBox1.Text = "Verified";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(487, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 23);
            this.label4.TabIndex = 37;
            this.label4.Text = "Filter:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 22);
            this.textBox1.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 23);
            this.label3.TabIndex = 35;
            this.label3.Text = "Search:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.manageBooks);
            this.panel1.Location = new System.Drawing.Point(24, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 461);
            this.panel1.TabIndex = 101;
            // 
            // manageBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Name = "manageBooking";
            this.Size = new System.Drawing.Size(750, 700);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manageBooks)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView manageBooks;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnViewPend;
        private System.Windows.Forms.Panel panel1;
    }
}
