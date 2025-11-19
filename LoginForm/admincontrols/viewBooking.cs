using LoginForm.models;
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

namespace LoginForm.admincontrols
{
    public partial class viewBooking : UserControl
    {

        admincontrols.manageBooking mngBooking = new admincontrols.manageBooking();
        public viewBooking(string BookerEmail)
        {
            InitializeComponent();
            LoadBookingInfo(BookerEmail);
        }


        private async void LoadBookingInfo(string bookrEmail)
        {
            try
            {
                var info = await MongoDbServices.BusBooking
                    .Find(x => x.Email == bookrEmail)
                    .FirstOrDefaultAsync();
                if (info != null) { 
                    fullName.Text = info.FullName;
                    email.Text = info.Email;
                    contactNum.Text = info.Phone;
                    busType.Text = info.Bus;
                    destination.Text = info.Destination;
                    returnDate.Text = info.Return;
                    departureDate.Text = info.Departure;
                    price.Text = info.Price.ToString();
                    status_combo.Text = info.Status;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading booking info: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(mngBooking);
            panel.Dock = DockStyle.Fill;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(status_combo.Text))
            {
                MessageBox.Show("Please select a status.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string status = status_combo.Text.ToString();
            string email = Session.CurrentBookerSelected;

            var booking = await MongoDbServices.BusBooking
                .Find(x => x.Email == email)
                .FirstOrDefaultAsync();

            if (booking == null)
            {
                MessageBox.Show("Booking not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string key = "Admin";
            DateTime date = DateTime.Now;
            string remarks = remarks_input.Text.ToString().ToLower();

            string message = "";
            string type = "";

            switch (status.ToLower())
            {
                case "approved":
                    message = $"Bus booking for {booking.FullName} status has been updated to approved.";
                    type = "Success";
                    break;

                case "pending":
                    message = $"Bus booking for {booking.FullName} is currently pending for review. Please wait for confirmation.";
                    type = "Info";
                    break;

                case "paid":
                    message = $"Bus booking for {booking.FullName} has been successfully paid!";
                    type = "Success";
                    break;

                case "rejected":
                    message = $"Bus booking for {booking.FullName} submission was not approved. Please review the requirements and resubmit.";
                    type = "Error";
                    break;

                default:
                    MessageBox.Show("Please select a valid status.", "Invalid Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            var notif = new UserNotificationModel
            {
                NotificationId = booking.UserID,
                Key = key,
                HeaderMessage = message,
                Type = type,
                Remarks = remarks,
                Date = date
            };

            await MongoDbServices.UserNotification.InsertOneAsync(notif);

            // Update booking status
            var filter = Builders<BusBookingModel>.Filter.Eq(x => x.Email, email);
            var update = Builders<BusBookingModel>.Update.Set(x => x.Status, status);

            await MongoDbServices.BusBooking.UpdateOneAsync(filter, update);

            MessageBox.Show($"Bus booking for {booking.FullName} has been {status}.",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            panel.Controls.Clear();
            panel.Controls.Add(new manageBooking());
            new manageBooking().Dock = DockStyle.Fill;

        }

    }
        }
