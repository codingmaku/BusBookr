using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm.models
{
    public class BusRouteModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string Id { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string CoasterBusPrice{ get; set; }
        public string TouristBusPrice{ get; set; }
    }
}
