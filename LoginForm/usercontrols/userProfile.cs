using System;
using LoginForm.services;
using System.Windows.Forms;
using MongoDB.Driver;

namespace LoginForm.usercontrols
{
    public partial class userProfile : UserControl
    {
        public userProfile()
        {
            InitializeComponent();
            LoadUserProfile();
        }

        private async void LoadUserProfile()
        {
            try
            {
                var user = await MongoDbServices.UserAccount
                    .Find(x => x.Id == Session.UserId)
                    .FirstOrDefaultAsync();

                if (user != null)
                {
                    fullName_user.Text = user.FullName;
                    phoneNumber_user.Text = user.Number;
                    email_user.Text = user.Email;
                }
                else
                {
                    MessageBox.Show("User profile not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error occurred while loading user profile: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void userProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
