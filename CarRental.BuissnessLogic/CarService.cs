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
    public class CarService
    {
        private CarRentalContext inputUserData = new CarRentalContext();

        public void AddCar(Car car)
        {
            inputUserData.Cars.Add(car);
            inputUserData.SaveChanges();
        }

        public void RemoveCar(Car car)
        {
            inputUserData.Cars.Remove(car);
            inputUserData.SaveChanges();
        }

        public List<Car> GetAllCars()
        {
            var cars = inputUserData.Cars.ToList();
            return cars;
        }

        public Car GetCarById(int id)
        {
            var car = inputUserData.Cars.Single(c => c.Id == id);

            return car;
        }
    }
}
