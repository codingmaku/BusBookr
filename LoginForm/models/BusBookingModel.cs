using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm.models
{
    public class BusBookingModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string Id { get; set; }  
        public string UserID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Bus { get; set; }
        public string Destination { get; set; }
        public int Price { get; set; }
        public string Departure { get; set; }
        public string Return { get; set; }
        public string Status { get; set; } = "Pending";
    }
}
