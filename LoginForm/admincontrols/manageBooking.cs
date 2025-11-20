using LoginForm.admincontrols;
using LoginForm.models;
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
            manageBooks.Columns.Add("Id", "Id");
            manageBooks.Columns["Id"].Visible = false;

            var actionButton = new DataGridViewButtonColumn();
            actionButton.Name = "Action";
            actionButton.HeaderText = "Action";
            actionButton.Text = ">";
            actionButton.UseColumnTextForButtonValue = true;
            actionButton.FlatStyle = FlatStyle.Flat;
            actionButton.Width = 60;
            actionButton.DefaultCellStyle.Font = new Font("Poppins", 12, FontStyle.Bold);

            manageBooks.Columns.Add(actionButton);

            status_combo.SelectedIndex = 1;
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void manageBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == manageBooks.Columns["Action"].Index)
            {
                string email = manageBooks.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                string id = manageBooks.Rows[e.RowIndex].Cells["Id"].Value.ToString();

                Session.CurrentBookerSelectedId = id;
                Session.CurrentBookerSelectedEmail = email;

                admincontrols.viewBooking vwbk = new admincontrols.viewBooking(id, email);
                panel.Controls.Clear();
                panel.Controls.Add(vwbk);
                panel.Dock = DockStyle.Fill;
            }
        }
        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string response = status_combo.Text.ToLower();

            switch (response)
            {
                case "pending":
                    manageBooks.Rows.Clear();

                    var filterPending = Builders<BusBookingModel>.Filter.Eq(x => x.Status, "Pending");

                    var pendingAccounts = await MongoDbServices.BusBooking
                        .Find(filterPending)
                        .ToListAsync();

                    if (pendingAccounts != null)
                    {
                        pendingAccounts.ForEach(pending => {

                            manageBooks.Rows.Add(
                                pending.FullName,
                                pending.Email,
                                pending.Bus,
                                pending.Status,
                                pending.Id
                            );

                        });
                    }
                    break;

                case "approved":
                    manageBooks.Rows.Clear();
                    var filterVerified = Builders<BusBookingModel>.Filter.Eq(x => x.Status, "Approved");

                    var verifiedAccount = await MongoDbServices.BusBooking
                        .Find(filterVerified)
                        .ToListAsync();

                    if (verifiedAccount != null)
                    {
                        verifiedAccount.ForEach(book => {
                            manageBooks.Rows.Add(
                                 book.FullName,
                                 book.Email,
                                 book.Bus,
                                 book.Status,
                                 book.Id
                             );

                        });
                    }
                    break;

                case "paid":
                    manageBooks.Rows.Clear();
                    var filterIncomplete = Builders<BusBookingModel>.Filter.Eq(x => x.Status, "Paid");

                    var incompleteAccount = await MongoDbServices.BusBooking
                        .Find(filterIncomplete)
                        .ToListAsync();


                    if (incompleteAccount != null)
                    {
                        incompleteAccount.ForEach(book => {
                            manageBooks.Rows.Add(
                                 book.FullName,
                                 book.Email,
                                 book.Bus,
                                 book.Status,
                                 book.Id
                             );

                        });
                    }
                    break;

                case "rejected":
                    manageBooks.Rows.Clear();
                    var filterRejected = Builders<BusBookingModel>.Filter.Eq(x => x.Status, "Rejected");

                    var rejectedAccount = await MongoDbServices.BusBooking
                        .Find(filterRejected)
                        .ToListAsync();


                    if (rejectedAccount != null)
                    {
                        rejectedAccount.ForEach(book => {
                            manageBooks.Rows.Add(
                                 book.FullName,
                                 book.Email,
                                 book.Bus,
                                 book.Status,
                                 book.Id
                             );


                        });
                    }
                    break;

                case "all":
                    manageBooks.Rows.Clear();

                    var allAccount = await MongoDbServices.BusBooking
                        .Find(_ => true)
                        .ToListAsync();
                    if (allAccount != null)
                    {
                        allAccount.ForEach(book => {
                            manageBooks.Rows.Add(
                                 book.FullName,
                                 book.Email,
                                 book.Bus,
                                 book.Status,
                                 book.Id
                             );

                        });
                    }
                    break;

                default:
                    MessageBox.Show("Please select a valid status.", "Invalid Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }
    }
}
