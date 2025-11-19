using Amazon.Runtime.Internal;
using LoginForm.services;
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

namespace LoginForm.usercontrols
{
    public partial class addBooking : UserControl
    {
        public addBooking()
        {
            InitializeComponent();
            PutPredefinedData();
        }

        private void btnViewBus_Click(object sender, EventArgs e)
        {
            new viewRatea().Show();

        }

        private void userBooking_Load(object sender, EventArgs e)
        {

        }

        private async void btnBookNow_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fullName_user.Text)
                || string.IsNullOrEmpty(email_user.Text)
                || string.IsNullOrEmpty(phoneNumber_user.Text)
                || string.IsNullOrEmpty(typeofbus_user.Text)
                || string.IsNullOrEmpty(price_user.Text)
                || string.IsNullOrEmpty(destination_user.Text)
                || string.IsNullOrEmpty(departureDate_user.Text)
                || string.IsNullOrEmpty(returnDate_user.Text)) 
            {
                MessageBox.Show("Please complete the form before booking", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                bool response = await MongoDbServices.InsertBusBookingAsync(
                "123123",
                fullName_user.Text,
                email_user.Text, 
                phoneNumber_user.Text, 
                typeofbus_user.Text, 
                destination_user.Text, 
                int.Parse(price_user.Text), 
                departureDate_user.Text, 
                returnDate_user.Text); 
            
            if (response)
            {
                string result = MessageBox.Show(
                    "Bus successfully booked and ready for review",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                ).ToString();

                if (result == "OK")
                {
                    typeofbus_user.SelectedIndex = -1;
                    destination_user.SelectedIndex = -1;
                    price_user.Text = " ";
                    departureDate_user.Text = "";
                    returnDate_user.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Failed to add booking. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private async void PutPredefinedData()
        {
            try
            {
                var user = await MongoDbServices.UserAccount
                    .Find(x => x.Id == Session.UserId)
                    .FirstOrDefaultAsync();

                if (user != null)
                {
                    fullName_user.Text = user.FullName;
                    phoneNumber_user.Text = user.Number;
                    email_user.Text = user.Email;
                }
                else
                {
                    MessageBox.Show("User profile not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error occurred while loading user profile: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
