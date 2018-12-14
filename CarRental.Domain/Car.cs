using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Domain
{
    [DataContract]
    public class Car
    {
        public Car()
        {
            Bookings = new List<Booking>();
        }

        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string RegistrationNumber { get; set; }
        [DataMember]
        public string Brand { get; set; }
        [DataMember]
        public string Mark { get; set; }
        [DataMember]
        public DateTime Year { get; set; }
        [DataMember]
        public List<Booking> Bookings { get; set; }
        [DataMember]
        public bool IsReturned { get; set; }
    }
}
