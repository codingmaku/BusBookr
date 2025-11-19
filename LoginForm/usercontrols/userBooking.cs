using LoginForm.styles;
using System;
using MongoDB.Driver;
using System.Windows.Forms;

namespace LoginForm.usercontrols
{
    public partial class userBooking : UserControl
    {
        public userBooking()
        {
            InitializeComponent();
            tableStyles.Tables(viewBooking);

            viewBooking.Columns.Add("Destination", "Destination");
            viewBooking.Columns.Add("Bus", "Bus");
            viewBooking.Columns.Add("Departure", "Departure");
            viewBooking.Columns.Add("Return", "Return");
            viewBooking.Columns.Add("Status", "Status");
            LoadMyBookings();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void LoadMyBookings()
        {
            try { 
                var bookings = await services.MongoDbServices.BusBooking
                    .Find(x => x.UserID == Session.UserId)
                    .ToListAsync();

                if (bookings.Count > 0) { 
                    bookings.ForEach(book =>
                    {
                        viewBooking.Rows.Add(
                            book.Destination,
                            book.Bus,
                            book.Departure.ToString(),
                            book.Return.ToString(),
                            book.Status
                        );
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading bookings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
