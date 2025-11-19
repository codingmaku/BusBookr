using LoginForm.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm.admincontrols
{
    public partial class manageAdmin : UserControl
    {
        public manageAdmin()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void btnAddAdmin_Click(object sender, EventArgs e)
        {
            
            
            
        if (string.IsNullOrEmpty(fullName_admin.Text)

                || string.IsNullOrEmpty(email_admin.Text)
                || string.IsNullOrEmpty(roles_admin.Text)
                || string.IsNullOrEmpty(password_admin.Text)
                || string.IsNullOrEmpty(confirmPass_admin.Text)
                || string.IsNullOrEmpty(roles_admin.Text))

            {
                MessageBox.Show(
                    "Please input all fields before proceeding",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password_admin.Text != confirmPass_admin.Text) {
                MessageBox.Show("Password does not match",
                    "Validation Error");
                return;
            }

                
            bool response = await MongoDbServices.InsertAdminAccountAsync(
                fullName_admin.Text,
                email_admin.Text,
                roles_admin.Text,
                password_admin.Text,
                status_admin.Text);

            if (response)
            {
                string result = MessageBox.Show(
                    "Admin successfully added",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                ).ToString();

                if (result == "OK")
                {
                    fullName_admin.Clear();
                    email_admin.Clear();                  
                    roles_admin.SelectedIndex = -1;
                    password_admin.Clear();
                    confirmPass_admin.Clear();
                    status_admin.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show(
                        "Please input other fields",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
