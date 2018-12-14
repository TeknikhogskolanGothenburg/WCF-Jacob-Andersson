using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Data;
using CarRental.Domain;
using Microsoft.EntityFrameworkCore;

namespace CarRental.BuissnessLogic
{
    public class BookingService
    {
        private CarRentalContext inputUserData = new CarRentalContext();

        public void AddBooking(Booking booking)
        {
            inputUserData.Bookings.Add(booking);
            inputUserData.SaveChanges();
        }

        public void RemoveBooking(Booking booking)
        {
            inputUserData.Bookings.Remove(booking);
            inputUserData.SaveChanges();
        }

        public List<Car> GetAvaliableCars(DateTime starDateTime, DateTime endDateTime)
        {         
            CarService dataCarService = new CarService();
            //var cars = inputUserData.Cars.ToList();c.Bookings == null ||
            List<Car> cars1 = dataCarService.GetAllCars();

            List<Car> avaliableCars = inputUserData.Cars.Include(c => c.Bookings).ToList().Where(c =>
                    c.Bookings == null ||
                    c.Bookings.Where(b => !(b.StartTime > endDateTime || b.EndTime < starDateTime)).ToList().Count == 0)
                .ToList();

            avaliableCars.ForEach(c=> c.Bookings = new List<Booking>());

            return avaliableCars;
        }

        public void LendCar(Car car)
        {
            inputUserData.Cars.Find(car.Id).IsReturned = false;
            inputUserData.SaveChanges();
        }

        public void ReturnCar(Car car)
        {
            inputUserData.Cars.Find(car.Id).IsReturned = true;
            inputUserData.SaveChanges();
        }

        public List<Booking> GetAllBookings()
        {
            var bookings = inputUserData.Bookings.ToList();
            return bookings;
        }

        public Booking GetBookingById(int id)
        {
            var booking = inputUserData.Bookings.Single(b => b.Id == id);

            return booking;
        }
    }
}
