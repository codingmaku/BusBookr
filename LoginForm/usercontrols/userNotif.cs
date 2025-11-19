using LoginForm.controllers;
using LoginForm.services;
using System;
using MongoDB.Driver;
using System.Linq;
using System.Windows.Forms;

namespace LoginForm.usercontrols
{
    public partial class userNotif : UserControl
    {
        private NotificationFlowManager notificationManager;
        public userNotif()
        {
            InitializeComponent();
            LoadUserNotif();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void LoadUserNotif()
        {
            var booker = await MongoDbServices.UserNotification
                .Find(x => x.NotificationId == Session.UserId)
                .ToListAsync();
            Console.WriteLine(booker.Count);

            if (booker.Count > 0)
            {
                notificationManager = new NotificationFlowManager(notif_panel);
                foreach (var notif in booker)
                {
                    notificationManager.AddNotification(notif.Key, notif.HeaderMessage, notif.Remarks, notif.Type, notif.Date);
                }
            }
        }

    }
}
