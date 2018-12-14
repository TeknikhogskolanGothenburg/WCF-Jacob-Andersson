using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CarRental.Domain;

namespace CarRentalServiceREST
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RestService" in both code and config file together.
    public class RestService : IRestService
    {
        public List<Car> GetAllCars()
        {
            var dataCar = new CarRental.BuissnessLogic.CarService();
            var cars = dataCar.GetAllCars();

            return cars;
        }

        public void AddNewCar(Car car)
        {
            var dataCar = new CarRental.BuissnessLogic.CarService();
            dataCar.AddCar(car);
        }

        public Car GetCarById(string id)
        {
            var dataCar = new CarRental.BuissnessLogic.CarService();
            var car = dataCar.GetCarById(Convert.ToInt32(id));

            return car;
        }

        public void DeleteCar(Car car)
        {
            var dataCar = new CarRental.BuissnessLogic.CarService();
            dataCar.RemoveCar(car);
        }
    }
}
