using LoginForm.admincontrols;
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
    public partial class manageBooking : UserControl
    {


        public manageBooking()
        {
            InitializeComponent();
            tableStyles.Tables(manageBooks);

            manageBooks.Columns.Add("Name", "Name");
            manageBooks.Columns.Add("Email", "Email");
            manageBooks.Columns.Add("Bus", "Bus");
            manageBooks.Columns.Add("Status", "Status");

            var actionButton = new DataGridViewButtonColumn();
            actionButton.Name = "Action";
            actionButton.HeaderText = "Action";
            actionButton.Text = ">";
            actionButton.UseColumnTextForButtonValue = true;
            actionButton.FlatStyle = FlatStyle.Flat;
            actionButton.Width = 60;
            actionButton.DefaultCellStyle.Font = new Font("Poppins", 12, FontStyle.Bold);

            manageBooks.Columns.Add(actionButton);
            LoadBookings();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void manageBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == manageBooks.Columns["Action"].Index)
            {
                string email = manageBooks.Rows[e.RowIndex].Cells["Email"].Value.ToString();

                Session.CurrentBookerSelected = email;

                admincontrols.viewBooking vwbk = new admincontrols.viewBooking(email);
                panel.Controls.Clear();
                panel.Controls.Add(vwbk);
                panel.Dock = DockStyle.Fill;
            }
        }

        private async void LoadBookings()
        {
            try {
                var booking = await MongoDbServices.BusBooking
                .Find(_ => true)
                .ToListAsync();

                if (booking.Count > 0) { 
                    booking.ForEach(book =>
                    {
                        manageBooks.Rows.Add(
                            book.FullName,
                            book.Email,
                            book.Bus,
                            book.Status
                        );
                    });
                }

            } catch(Exception e)
            {
                MessageBox.Show("Error loading bookings: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
