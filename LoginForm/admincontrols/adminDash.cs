using LoginForm.services;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;

namespace LoginForm.admincontrols
{
    public partial class adminDash : UserControl
    {
        public adminDash()
        {
            InitializeComponent();
            LoadStats();
        }

        private void adminDash_Load(object sender, EventArgs e)
        {

        }



private async void LoadStats()
    {
        // Define Philippine peso culture
        CultureInfo php = new CultureInfo("en-PH");

        // Count pending jobs
        var businessActiveJobs = await MongoDbServices.BusBooking
            .CountDocumentsAsync(x => x.Status == "Pending");
        pendingReq.Text = businessActiveJobs.ToString();

        // Today's range
        var today = DateTime.Today;
        var tomorrow = today.AddDays(1);

        // Revenue for today
        var paidToday = await MongoDbServices.BusBooking
            .Find(x => x.Status == "Paid" && x.CreatedAt >= today && x.CreatedAt < tomorrow)
            .ToListAsync();

        decimal totalTodayRevenue = paidToday.Sum(x => Convert.ToDecimal(x.Price));
        revToday.Text = totalTodayRevenue.ToString("C", php); // ₱ formatting

        // Overall revenue
        var allPaid = await MongoDbServices.BusBooking
            .Find(x => x.Status == "Paid")
            .ToListAsync();

        decimal totalOverallRevenue = allPaid.Sum(x => Convert.ToDecimal(x.Price));
        overallRev.Text = totalOverallRevenue.ToString("C", php); // ₱ formatting
    }



}
}
