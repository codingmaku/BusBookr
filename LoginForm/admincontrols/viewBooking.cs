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
        OpenFileDialog opfidi = new OpenFileDialog();
        admincontrols.manageBooking mngBooking = new admincontrols.manageBooking();
        public viewBooking()
        {
            InitializeComponent();
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

        private void label14_Click(object sender, EventArgs e)
        {
                    }
    }
}
