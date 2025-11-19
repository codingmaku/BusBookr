using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm.models
{
    public class UserNotificationModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string NotificationId { get; set; }
        public string Key { get; set; }
        public string HeaderMessage { get; set; }
        public string Remarks { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public Boolean IsRead { get; set; } = false;
    }
}
