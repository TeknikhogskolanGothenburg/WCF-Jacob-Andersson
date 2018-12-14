using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Data;
using CarRental.Domain;

namespace CarRental.BuissnessLogic
{
    public class CustomerService
    {
        private CarRentalContext inputUserData = new CarRentalContext();

        public void AddCustomer(Customer customer)
        {
            inputUserData.Customers.Add(customer);
            inputUserData.SaveChanges();
        }

        public void ChangeCustomer(Customer customer)
        {
            inputUserData.Customers.Update(customer);
            inputUserData.SaveChanges();
        }

        public void RemoveCustomer(Customer customer)
        {
            inputUserData.Customers.Remove(customer);
            inputUserData.SaveChanges();
        }

        public List<Customer> GetAllCustomers()
        {
            var customers = inputUserData.Customers.ToList();
            return customers;
        }

        public Customer GetCustomerById(int id)
        {
            var customer = inputUserData.Customers.Single(c => c.Id == id);

            return customer;
        }

        public CustomerInfo GetCustomerByEmail(CustomerRequest request)
        {
            var customer = inputUserData.Customers.Single(c => c.Email == request.CustomerEmail);

            return new CustomerInfo(customer);
        }
    }
}
