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
    public partial class addDestination : UserControl
    {
        public addDestination()
        {
            InitializeComponent();
        }

        private void userStaff_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void btnTickets_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(origin_admin.Text)
                || string.IsNullOrEmpty(destination_admin.Text)
                || string.IsNullOrEmpty(coasterBus_admin.Text)
                || string.IsNullOrEmpty(touristBus_admin.Text))
            {
                MessageBox.Show(
                    "Please input all fields before proceeding", 
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool response = await MongoDbServices.InsertBusRouteAsync(
                origin_admin.Text,
                destination_admin.Text,
                coasterBus_admin.Text,
                touristBus_admin.Text);
            if (response)
            {
                string result = MessageBox.Show(
                    "Destination and Bus Rate successfully added",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                ).ToString();

                if (result == "OK")
                {
                    origin_admin.Clear();
                    destination_admin.Clear();
                    coasterBus_admin.Clear();
                    touristBus_admin.Clear();
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
