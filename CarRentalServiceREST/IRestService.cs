using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using CarRental.Domain;
using System.Text;

namespace CarRentalServiceREST
{
    [ServiceContract]
    public interface IRestService
    {
        [OperationContract]
        [WebGet(UriTemplate = "Cars",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        List<Car> GetAllCars();

        [OperationContract]
        [WebInvoke(Method = "POST",
            UriTemplate = "AddCar",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped)]
        void AddNewCar(Car car);

        [OperationContract]
        [WebGet(UriTemplate = "Cars/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Car GetCarById(string id);

        [OperationContract]
        [WebInvoke(Method = "DELETE",
            UriTemplate = "DeleteCar",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        void DeleteCar(Car car);
    }
}
