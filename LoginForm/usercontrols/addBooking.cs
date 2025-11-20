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
            LoadDestinations();

            destination_user.Enabled = false;
            returnDate_user.Enabled = false;
            departureDate_user.Enabled = false;
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
        private async void LoadDestinations()
        {
            try
            {

                var routes = await MongoDbServices.BusRoute
                .Find(_ => true)
                .ToListAsync();
                if (routes != null && routes.Count > 0)
                {
                    var uniqueDestinations = routes
                    .Select(x => x.Destination)
                    .Distinct()
                    .ToList();
                    destination_user.Items.Clear();
                    foreach (var des in uniqueDestinations) { 
                        destination_user.Items.Add(des);
                    }

                }

                else
                {
                    MessageBox.Show("Destinations not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error occurred while loading destinations: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private async void btnBookNow_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fullName_user.Text)
               || string.IsNullOrEmpty(email_user.Text)
               || string.IsNullOrEmpty(phoneNumber_user.Text)
               || string.IsNullOrEmpty(typeofbus_user.Text)
               || string.IsNullOrEmpty(fprice_user.Text)
               || string.IsNullOrEmpty(destination_user.Text)
               || string.IsNullOrEmpty(departureDate_user.Text)
               || string.IsNullOrEmpty(returnDate_user.Text))
            {
                MessageBox.Show("Please complete the form before booking", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool response = await MongoDbServices.InsertBusBookingAsync(
            Session.UserId,
            fullName_user.Text,
            email_user.Text,
            phoneNumber_user.Text,
            typeofbus_user.Text,
            destination_user.Text,
            int.Parse(fprice_user.Text),
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
                    usercontrols.addBooking addBook = new usercontrols.addBooking();
                    panel.Controls.Clear();
                    panel.Controls.Add(addBook);
                    addBook.Dock = DockStyle.Fill;
                }
            }
            else
            {
                MessageBox.Show("Failed to add booking. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewBus_Click_1(object sender, EventArgs e)
        {
            new viewRatea().Show();
        }

        private void typeofbus_user_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            destination_user.Enabled = true;
        }

        private async void destination_user_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (typeofbus_user.SelectedIndex == -1 && destination_user.SelectedIndex == -1)
            {
                fprice_user.Text = "";
                return;
            }
            departureDate_user.Enabled = true;
            string busSelected = typeofbus_user.SelectedItem.ToString();
            string destinationSelected = destination_user.SelectedItem.ToString();

            if (busSelected == "Coaster Bus")
            {
                var route = await MongoDbServices.BusRoute
                    .Find(x => x.Destination == destinationSelected)
                    .FirstOrDefaultAsync();

                if (route != null)
                {
                    price_user.Text = route.CoasterBusPrice.ToString();
                }
            }
            else if (busSelected == "Tourist Bus")
            {
                var route = await MongoDbServices.BusRoute
                    .Find(x => x.Destination == destinationSelected)
                    .FirstOrDefaultAsync();
                if (route != null)
                {
                    price_user.Text = route.TouristBusPrice.ToString();
                }

            }

        }

        private void returnDate_user_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime depDate = DateTime.Parse(departureDate_user.Text);
            DateTime retDate = DateTime.Parse(returnDate_user.Text);

            // Calculate days (minimum 1 day)
            int totalDays = (retDate - depDate).Days;
            if (totalDays < 1) totalDays = 1;

            // Convert entered price (per day price)
            int pricePerDay = int.Parse(price_user.Text);

            // Final price
            int finalPrice = totalDays * pricePerDay;

            fprice_user.Text = finalPrice.ToString();
        }
        private void departureDate_user_ValueChanged_1(object sender, EventArgs e)
        {
            returnDate_user.Enabled = true;

        }
    }
}
