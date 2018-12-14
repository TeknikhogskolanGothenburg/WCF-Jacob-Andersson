using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Domain
{
    [DataContract]
    public class Booking
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public Car TheCar { get; set; }
        [DataMember]
        public int CarId { get; set; }
        [DataMember]
        public Customer TheCustomer { get; set; }
        [DataMember]
        public int CustomerId { get; set; }
        [DataMember]
        public DateTime StartTime { get; set; }
        [DataMember]
        public DateTime EndTime { get; set; }
    }
}
