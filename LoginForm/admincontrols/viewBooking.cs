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
                    status.Text = info.Status;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading booking info: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(mngBooking);
            panel1.Dock = DockStyle.Fill;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }
    }
}
