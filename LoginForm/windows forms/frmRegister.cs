using LoginForm.services;
using MongoDB.Bson.Serialization.Attributes;
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

namespace LoginForm
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text)

                || string.IsNullOrEmpty(txtEmail.Text)
                || string.IsNullOrEmpty(txtNumber.Text)
                || string.IsNullOrEmpty(txtPass.Text)
                || string.IsNullOrEmpty(txtConfirm.Text))
            {
                MessageBox.Show(
                    "Please input all fields before proceeding",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPass.Text != txtConfirm.Text)
            {
                MessageBox.Show("Password does not match",
                    "Validation Error");
                return;
            }


            bool response = await MongoDbServices.InsertUserAccountAsync(
                txtUser.Text,
                txtNumber.Text,
                txtEmail.Text,
                txtPass.Text
                );

            if (response)
            {
                string result = MessageBox.Show(
                    "Account successfully created",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                ).ToString();

                if (result == "OK")
                {
                    txtUser.Clear();
                    txtNumber.Clear();
                    txtEmail.Clear();
                    txtPass.Clear();
                    txtConfirm.Clear();

                    this.Dispose();

                    frmLogin loginForm = new frmLogin();
                    loginForm.Show();

                }
                else
                {
                    MessageBox.Show(
                        "Please input other fields",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
          
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
        }    

        private void txtConf_TextChanged(object sender, EventArgs e)
        {
            txtConfirm.UseSystemPasswordChar = true;
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUser.Text = string.Empty;
            txtPass.Text = string.Empty;
            txtConfirm.Text = string.Empty;
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = !cbShowPass.Checked;
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmLogin loginForm = new frmLogin();
            loginForm.Show();
        }
    }

    public class Register {
        [BsonId]
        public string ObjectId { get; set; }

        [BsonElement("username")]

        public string Username { get; set; }


        [BsonElement("number")]

        public string ContactNum { get; set; }

        [BsonElement("email")]
        public string email { get; set; }

        [BsonElement("password")]

        public string Password { get; set; }


        [BsonElement("confirmpassword")]

        public string ConfirmPassword { get; set; }

        public Register(string email, string contact, string username, string password, string confirmPassword)
        {
            this.email = email;
            this.ContactNum = contact;
            this.ObjectId = username;
            this.Password = password;
            this.ConfirmPassword = confirmPassword;
        }
    }
    
}
