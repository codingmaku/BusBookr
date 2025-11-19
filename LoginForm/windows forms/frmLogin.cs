using LoginForm.services;
using LoginForm.usercontrols;
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
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {           
  
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text)
                || string.IsNullOrEmpty(txtPass.Text)) {
                MessageBox.Show("Please enter Email and Password");
                return;
            }

            bool success = await MongoDbServices.LoginBusBookrAccountAsync("booker", txtUser.Text, txtPass.Text);

            if (success)
            {
                MessageBox.Show("Login Successful");

                // SHOW NEXT FORM
                userView dashboard = new userView();
                dashboard.Show();

                this.Hide();
            }


        }
        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmRegister frmReg = new frmRegister();
            frmReg.Show();
        }
      
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmRegister frmReg = new frmRegister();
            frmReg.Show();
        }


        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = !cbShowPass.Checked;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();

            chooseLogin chsLogin = new chooseLogin();
            chsLogin.Show();
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();

            forgotPassword frgtPass = new forgotPassword();
            frgtPass.Show();
        }
    }
}
