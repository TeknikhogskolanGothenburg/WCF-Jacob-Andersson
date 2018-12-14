using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CarRental.Domain;

namespace CarRentalService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICarService" in both code and config file together.
    [ServiceContract]
    public interface ICarService
    {
        [OperationContract]
        void AddCar(Car car);

        [OperationContract]
        void RemoveCar(Car car);

        [OperationContract]
        List<Car> GetAllCars();

        [OperationContract]
        Car GetCarById(int id);
    }
}
