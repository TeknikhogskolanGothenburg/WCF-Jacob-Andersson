using CarRental.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalService
{
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        void AddCustomer(Customer customer);

        [OperationContract]
        void RemoveCustomer(Customer customer);

        [OperationContract]
        void ChangeCustomer(Customer customer);

        [OperationContract]
        List<Customer> GetAllCustomers();

        [OperationContract]
        Customer GetCustomerById(int id);

        [OperationContract]
        CustomerInfo GetCustomerByEmail(CustomerRequest request);
    }
}
