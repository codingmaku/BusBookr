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
    public partial class userView : Form
    {
        usercontrols.userProfile userProf = new usercontrols.userProfile();
        usercontrols.userDash userDashboard = new usercontrols.userDash();
        usercontrols.userBooking userBooks = new usercontrols.userBooking();
        usercontrols.addBooking addBook = new usercontrols.addBooking();
        usercontrols.userNotif userNotification = new usercontrols.userNotif();
        
  

        public userView()
        {
            InitializeComponent();
            panel.Controls.Clear();
            panel.Controls.Add(userDashboard);
            userDashboard.Dock = DockStyle.Fill;
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(userProf);
            userProf.Dock = DockStyle.Fill;
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(addBook);
            addBook.Dock = DockStyle.Fill;
        }

        private void btnViewBook_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(userBooks);
            userBooks.Dock = DockStyle.Fill;
        }
    
        private void btnNotif_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(userNotification);
            userNotification.Dock = DockStyle.Fill;
        }        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            string response = MessageBox.Show("Are you sure you want to Sign Out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
            if (response == "Yes")
            {
                Application.Restart();
            }
            else
            {
                return;
            }     
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(userDashboard);
            userDashboard.Dock = DockStyle.Fill;
        }
    }


    }

