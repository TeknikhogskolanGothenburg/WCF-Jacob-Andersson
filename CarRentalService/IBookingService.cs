using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using CarRental.Domain;

namespace CarRentalService
{
    [ServiceContract]
    public interface IBookingService
    {
        [OperationContract]
        void AddBooking(Booking booking);

        [OperationContract]
        void RemoveBooking(Booking booking);

        [OperationContract]
        List<Car> GetAvaliableCars(DateTime starDateTime, DateTime endDateTime);

        [OperationContract]
        void LendCar(Car car);

        [OperationContract]
        void ReturnCar(Car car);

        [OperationContract]
        List<Booking> GetAllBookings();

        [OperationContract]
        Booking GetBookingById(int id);
    }
}
