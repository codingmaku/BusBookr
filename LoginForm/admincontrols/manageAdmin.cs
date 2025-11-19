using LoginForm.services;
using LoginForm.styles;
using MongoDB.Driver;
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

            tableStyles.Tables(admin_table);

            admin_table.Columns.Add("FullName", "FullName");
            admin_table.Columns.Add("Email", "Email");
            admin_table.Columns.Add("Role", "Bus");
            admin_table.Columns.Add("Departure", "Status");

            var update = new DataGridViewButtonColumn();
            update.Name = "Update";
            update.HeaderText = "Action";
            update.Text = "Update";
            update.UseColumnTextForButtonValue = true;
            update.FlatStyle = FlatStyle.Flat;
            update.Width = 60;
            update.DefaultCellStyle.Font = new Font("Poppins", 12, FontStyle.Bold);

            admin_table.Columns.Add(update);

            var delete = new DataGridViewButtonColumn();
            delete.Name = "Delete";
            delete.Text = "Delete";
            delete.UseColumnTextForButtonValue = true;
            delete.FlatStyle = FlatStyle.Flat;
            delete.Width = 60;
            delete.DefaultCellStyle.Font = new Font("Poppins", 12, FontStyle.Bold);

            admin_table.Columns.Add(delete);

            LoadAdminAccounts();
            ShowSubmitButton();

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ShowSubmitButton()
        {
            btnAddAdmin.Visible = true;
            update_button.Visible = false;
        }
        private void ShowUpdateButton()
        {
            btnAddAdmin.Visible = false;
            update_button.Visible = true;
        }
        private void ClearForm()
        {
            fullName_admin.Clear();
            email_admin.Clear();
            roles_admin.SelectedIndex = -1;
            status_admin.SelectedIndex = -1;
            password_admin.Clear();
            confirmPass_admin.Clear();
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
                password_admin.Text,
                roles_admin.Text,
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
                    LoadAdminAccounts();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show(
                        "Please input other fields",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void LoadAdminAccounts()
        {
            admin_table.Rows.Clear();

            var adminAccounts = await MongoDbServices.AdminAccount
                .Find(_ => true)
                .ToListAsync();

            if (adminAccounts != null)
            {
                adminAccounts.ForEach(admin =>
                {
                    admin_table.Rows.Add(
                        admin.FullName,
                        admin.Email,
                        admin.Role,
                        admin.Status
                    );
                });
            }
        }

        private async void admin_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == admin_table.Columns["Update"].Index)
            {
                string email = admin_table.Rows[e.RowIndex].Cells["Email"].Value.ToString();

                var adminDetails = await MongoDbServices.AdminAccount
                    .Find(x => x.Email == email)
                    .FirstOrDefaultAsync();

                if (adminDetails != null)
                {
                    email_admin.Text = adminDetails.Email;
                    fullName_admin.Text = adminDetails.FullName;
                    roles_admin.SelectedItem = adminDetails.Role;
                    status_admin.SelectedItem = adminDetails.Status;
                    password_admin.Text = adminDetails.Password;
                    confirmPass_admin.Text = adminDetails.Password;

                    Session.CurrentAdminSelected = adminDetails.Id;

                    ShowUpdateButton();
                }
            }

            if (e.RowIndex >= 0 && e.ColumnIndex == admin_table.Columns["Delete"].Index)
            {
                string email = admin_table.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                var confirmResult = MessageBox.Show(
                    "Are you sure to delete this admin account?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (confirmResult == DialogResult.Yes)
                {
                    var deleteResult = await MongoDbServices.AdminAccount
                        .DeleteOneAsync(x => x.Email == email);

                    if (deleteResult.DeletedCount > 0)
                    {
                        admin_table.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show("Admin account deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete admin account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async void update_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(email_admin.Text) || string.IsNullOrEmpty(password_admin.Text) || string.IsNullOrEmpty(confirmPass_admin.Text)
                || string.IsNullOrEmpty(fullName_admin.Text) || roles_admin.SelectedIndex == -1 || status_admin.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (password_admin.Text != confirmPass_admin.Text)
                {
                    MessageBox.Show("Passwords do not match", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    bool response = await MongoDbServices.UpdateAdminAccountAsync(Session.CurrentAdminSelected, email_admin.Text, password_admin.Text, fullName_admin.Text,
                        roles_admin.SelectedItem.ToString(), status_admin.SelectedItem.ToString());

                    if (response)
                    {
                        string res = MessageBox.Show(
                            "Admin account udpated successfully and ready for review",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        ).ToString();

                        if (res == "OK")
                        {
                            ClearForm();
                            LoadAdminAccounts();
                            ShowSubmitButton();

                            Session.CurrentAdminSelected = null;

                        }
                    }
                }
            }
        }

    }
}
