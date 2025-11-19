using LoginForm.styles;
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
    public partial class userBooking : UserControl
    {
        public userBooking()
        {
            InitializeComponent();
            tableStyles.Tables(viewBooking);

            viewBooking.Columns.Add("Origin", "Origin");
            viewBooking.Columns.Add("Destination", "Destination");
            viewBooking.Columns.Add("Bus", "Bus");
            viewBooking.Columns.Add("Departure", "Departure");
            viewBooking.Columns.Add("Return", "Return");
            viewBooking.Columns.Add("Status", "Status");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
