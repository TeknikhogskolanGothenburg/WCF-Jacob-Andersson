using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalService;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
//using CarRentalServiceREST;

namespace CarRentalServiceHost
{
    class Program
    {
        static void Main()
        {
            using (ServiceHost host = new ServiceHost(typeof(CarRentalService.CarRentalService)))
            {
                host.Open();
                Console.WriteLine("Host started @ " + DateTime.Now.ToString());
                Console.ReadLine();
            }

            //WebServiceHost host = new WebServiceHost(typeof(CarRentalServiceREST.RestService),
            //    new Uri("http://localhost:8000"));

            //ServiceEndpoint ep = host.AddServiceEndpoint(
            //    typeof(CarRentalServiceREST.IRestService), new WebHttpBinding(), "");

            //host.Description.Endpoints[0].Behaviors.Add(
            //    new WebHttpBehavior { HelpEnabled = true });

            //ServiceDebugBehavior sdb = host.Description.Behaviors.Find<ServiceDebugBehavior>();

            //sdb.IncludeExceptionDetailInFaults = true;
            ////sdb.HttpsHelpPageEnabled = true;

            //host.Open();
            //Console.WriteLine("Service is running");
            //Console.ReadLine();
            //host.Close();
        }
    }
}
