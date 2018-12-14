using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using CarRental.Domain;

namespace CarRentalService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CarService" in both code and config file together.
    public class CarRentalService : ICarService, IBookingService, ICustomerService
    {
        //Car Operations
        public void AddCar(Car car)
        {
            var dataCar = new CarRental.BuissnessLogic.CarService();
            dataCar.AddCar(car);
        }

        public void RemoveCar(Car car)
        {
            var dataCar = new CarRental.BuissnessLogic.CarService();
            dataCar.RemoveCar(car);
        }

        public List<Car> GetAllCars()
        {
            var dataCar = new CarRental.BuissnessLogic.CarService();
            var cars = dataCar.GetAllCars();

            return cars;
        }

        public Car GetCarById(int id)
        {
            var dataCar = new CarRental.BuissnessLogic.CarService();
            var car = dataCar.GetCarById(id);

            if (car is null)
            {
                throw new NullReferenceException("there is not car with that ID");
            }
 
            return car;
        }

        //Booking Operations
        public void AddBooking(Booking booking)
        {
            var dataBook = new CarRental.BuissnessLogic.BookingService();
            dataBook.AddBooking(booking);
        }

        public void RemoveBooking(Booking booking)
        {
            var dataBook = new CarRental.BuissnessLogic.BookingService();
            dataBook.RemoveBooking(booking);
        }

        public List<Car> GetAvaliableCars(DateTime starDateTime, DateTime endDateTime)
        {
            var dataBook = new CarRental.BuissnessLogic.BookingService();
            var avaliableCars = dataBook.GetAvaliableCars(starDateTime, endDateTime);

            return avaliableCars;
        }

        public void LendCar(Car car)
        {
            var dataBook = new CarRental.BuissnessLogic.BookingService();
            dataBook.LendCar(car);
        }

        public void ReturnCar(Car car)
        {
            var dataBook = new CarRental.BuissnessLogic.BookingService();
            dataBook.ReturnCar(car);
        }

        public List<Booking> GetAllBookings()
        {
            var dataBook = new CarRental.BuissnessLogic.BookingService();
            var bookings = dataBook.GetAllBookings();

            return bookings;
        }

        public Booking GetBookingById(int id)
        {
            var dataBook = new CarRental.BuissnessLogic.BookingService();
            var booking = dataBook.GetBookingById(id);

            return booking;
        }

        //Customer Operations
        public void AddCustomer(Customer customer)
        {
            var dataCust = new CarRental.BuissnessLogic.CustomerService();
            dataCust.AddCustomer(customer);
        }

        public void RemoveCustomer(Customer customer)
        {
            var dataCust = new CarRental.BuissnessLogic.CustomerService();
            dataCust.RemoveCustomer(customer);
        }

        public void ChangeCustomer(Customer customer)
        {
            var dataCust = new CarRental.BuissnessLogic.CustomerService();
            dataCust.ChangeCustomer(customer);
        }

        public List<Customer> GetAllCustomers()
        {
            var dataCust = new CarRental.BuissnessLogic.CustomerService();
            var customers = dataCust.GetAllCustomers();

            return customers;
        }

        public Customer GetCustomerById(int id)
        {
            var dataCust = new CarRental.BuissnessLogic.CustomerService();
            var customer = dataCust.GetCustomerById(id);

            return customer;
        }

        public CustomerInfo GetCustomerByEmail(CustomerRequest request)
        {
            if (request.LicensKey != "ABC12")
            {
                throw new WebFaultException<string>(
                    "Wrong license key",
                    HttpStatusCode.Forbidden);
            }
            else
            {
                var dataCust = new CarRental.BuissnessLogic.CustomerService();
                var customer = dataCust.GetCustomerByEmail(request);

                return customer;
            }
        }
    }
}
