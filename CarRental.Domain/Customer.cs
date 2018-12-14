using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Domain
{
    [MessageContract(IsWrapped = true, WrapperName = "CustomerRequestObject", WrapperNamespace = "http://localhost:8080/Customer")]
    public class CustomerRequest
    {
        [MessageHeader(Namespace = "http://localhost:8080/Customer")]
        public string LicensKey { get; set; }

        [MessageBodyMember(Namespace = "http://localhost:8080/Customer")]
        public string CustomerEmail { get; set; }
    }

    [MessageContract(IsWrapped = true, WrapperName = "CustomerInfoObject", WrapperNamespace = "http://localhost:8080/Customer")]
    public class CustomerInfo
    {
        public CustomerInfo()
        {

        }

        public CustomerInfo(Customer customer)
        {
            Id = customer.Id;
            FirstName = customer.FirstName;
            LastName = customer.LastName;
            Email = customer.Email;
            PhoneNumber = customer.PhoneNumber;
        }

        [MessageBodyMember(Order = 1, Namespace = "http://localhost:8080/Customer")]
        public int Id { get; set; }
        [MessageBodyMember(Order = 2, Namespace = "http://localhost:8080/Customer")]
        public string FirstName { get; set; }
        [MessageBodyMember(Order = 3, Namespace = "http://localhost:8080/Customer")]
        public string LastName { get; set; }
        [MessageBodyMember(Order = 4, Namespace = "http://localhost:8080/Customer")]
        public int PhoneNumber { get; set; }
        [MessageBodyMember(Order = 5, Namespace = "http://localhost:8080/Customer")]
        public string Email { get; set; }
    }

    [DataContract]
    public class Customer
    {
        public Customer()
        {
            Bookings = new List<Booking>();
        }

        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public int PhoneNumber { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public List<Booking> Bookings { get; set; }
    }
}
