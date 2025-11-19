using LoginForm.styles;
using System;
using MongoDB.Driver;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class viewRatea : Form
    {
        public viewRatea()
        {
            InitializeComponent();
            tableStyles.Tables(busRates);

            busRates.Columns.Add("Origin", "Origin");
            busRates.Columns.Add("Destination", "Destination");
            busRates.Columns.Add("Coaster Bus Rate", "Coaster Bus Rate 1d");
            busRates.Columns.Add("Tourist Bus Rate", "Tourist Bus Rate 1d");
            LoadBusRatesTable();
        
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void LoadBusRatesTable()
        {
            try
            {
                var busRatesList = await services.MongoDbServices.BusRoute.Find(_ => true).ToListAsync();
                
                busRates.Rows.Clear();
                foreach (var rate in busRatesList)
                {
                    busRates.Rows.Add(
                        rate.Origin,
                        rate.Destination,
                        rate.CoasterBusPrice,
                        rate.TouristBusPrice
                    );
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading bus rates: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
