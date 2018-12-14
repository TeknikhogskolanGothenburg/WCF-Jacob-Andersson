using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.BuissnessLogic;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = new DateTime(2018,11,17);
            DateTime end = new DateTime(2018,11,18);
            CarService carlol = new CarService();
           
            BookingService bookingService = new BookingService();
            bookingService.GetAvaliableCars(start, end);
        }
    }
}
