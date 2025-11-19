using LoginForm.admincontrols;
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
    public partial class adminDashboard : Form
    {
        admincontrols.adminDash adDashboard = new admincontrols.adminDash();     
        admincontrols.manageBooking mngBooking = new admincontrols.manageBooking();
        admincontrols.addDestination addDstn = new admincontrols.addDestination();
        admincontrols.viewBooking viewBook = new admincontrols.viewBooking();
        admincontrols.manageAdmin mngAdmin = new admincontrols.manageAdmin();
        
        public adminDashboard()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(adDashboard);
            adDashboard.Dock = DockStyle.Fill;


        }

        private void btnaddDestination_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(mngBooking);
            mngBooking.Dock = DockStyle.Fill;
        }

        private void btnDestination_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(addDstn);
            addDstn.Dock = DockStyle.Fill;
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDestination_Click_1(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(addDstn);
            addDstn.Dock = DockStyle.Fill;
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(mngBooking);
            mngBooking.Dock = DockStyle.Fill;
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

        private void btnManage_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(mngAdmin);
            mngAdmin.Dock = DockStyle.Fill;
        }
    }
}
