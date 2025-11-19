using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginForm.admincontrols;
using LoginForm.styles;

namespace LoginForm.admincontrols
{
    public partial class manageBooking : UserControl
    {


        public manageBooking()
        {
            InitializeComponent();
            tableStyles.Tables(manageBooks);

            manageBooks.Columns.Add("Name", "Name");
            manageBooks.Columns.Add("Bus", "Bus");
            manageBooks.Columns.Add("Status", "Status");
        }

        private void btnViewPend_Click(object sender, EventArgs e)
        {
            admincontrols.viewBooking vwbk = new admincontrols.viewBooking();
            panel.Controls.Clear();
            panel.Controls.Add(vwbk);
            panel.Dock = DockStyle.Fill;
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
