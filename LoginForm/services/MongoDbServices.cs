using LoginForm.models;
using LoginForm.usercontrols;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LoginForm.services
{
    public class MongoDbServices
    {
        private static readonly MongoClient _client;
        private static readonly IMongoDatabase _database;

        static MongoDbServices()
        {
            _client = new MongoClient("mongodb://localhost:27017/");
            _database = _client.GetDatabase("BusBookr");

        }
        public static IMongoCollection<AdminAccountModel> AdminAccount =>
            _database.GetCollection<AdminAccountModel>("AdminAccounts");
        public static IMongoCollection<BusBookingModel> BusBooking =>
            _database.GetCollection<BusBookingModel>("BusBookings");
                public static IMongoCollection<BusRouteModel> BusRoute =>
            _database.GetCollection<BusRouteModel>("BusRoutes");
                public static IMongoCollection<UserAccountModel> UserAccount =>
            _database.GetCollection<UserAccountModel>("UserAccounts");

        public static async Task<bool> LoginBusBookrAccountAsync(string user, string email, string password)
        {
            if (user == "booker")
            {
                var booker = await UserAccount
                    .Find(x => x.Email == email)
                    .FirstOrDefaultAsync();
                if (booker == null)
                {
                    MessageBox.Show("Email not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (booker.Password != password)
                {
                    MessageBox.Show("Incorrect password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                Session.UserId = booker.Id;
                Session.UserEmail = booker.Email;

                return true;
            }
            else if (user == "admin")
            {
                var admin = await AdminAccount
                    .Find(x => x.Email == email)
                    .FirstOrDefaultAsync();
                if (admin == null)
                {
                    MessageBox.Show("Email not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (admin.Password != password)
                {
                    MessageBox.Show("Incorrect password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (admin.Status != "Active")
                {
                    MessageBox.Show("Account is inactive. Please contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                Session.UserId = admin.Id;
                Session.UserEmail = admin.Email;

                return true;
            }
            return false;
        }

        public static async Task<bool> InsertBusBookingAsync(string id, string fullname, string email, string phone, string bus, string destination, int price, string departuredate, string returndate)
        {
            try
            {
                var newBooking = new BusBookingModel
                {
                    UserID = id,
                    FullName = fullname,
                    Email = email,
                    Phone = phone,
                    Bus = bus,
                    Destination = destination,
                    Price = price,
                    Departure = departuredate,
                    Return = returndate
                };

                await BusBooking.InsertOneAsync(newBooking);
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred while creating Bus Booking: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static async Task<bool> InsertBusRouteAsync(string origin, string destination, string coasterbus, string touristbus)
        {
            try
            {
                var newRoute = new BusRouteModel
                {
                    Origin = origin,
                    Destination = destination,
                    CoasterBusPrice = coasterbus,
                    TouristBusPrice = touristbus,
                };

                await BusRoute.InsertOneAsync(newRoute);
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred while creating Bus Booking: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static async Task<bool> InsertAdminAccountAsync(string fullname, string email, string password, string role, string status)
        {
            try
            {
                var newAdmin = new AdminAccountModel
                {
                    FullName = fullname,
                    Email = email,
                    Password = password,
                    Role = role,
                    Status = status
                };

                await AdminAccount.InsertOneAsync(newAdmin);
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred while creating Bus Booking: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static async Task<bool> InsertUserAccountAsync(string fullname, string number, string email, string password)
        {
            try
            {
                var newUser = new UserAccountModel
                {
                    FullName = fullname,
                    Number = number,
                    Email = email,
                    Password = password,
                };

                await UserAccount.InsertOneAsync(newUser);
                return true;
            }


            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred while creating Bus Booking: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static async Task<bool> UpdateAdminAccountAsync(string id, string email, string password, string fullname, string role, string status)
        {
            try
            {
                var adminAccount = Builders<AdminAccountModel>.Filter.Eq(x => x.Id, id);

                var update = Builders<AdminAccountModel>.Update
                    .Set(x => x.Email, email)
                    .Set(x => x.Password, password)
                    .Set(x => x.FullName, fullname)
                    .Set(x => x.Role, role)
                    .Set(x => x.Status, status);

                await AdminAccount.UpdateOneAsync(adminAccount, update);
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred while updating admin account: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
    } 
}


