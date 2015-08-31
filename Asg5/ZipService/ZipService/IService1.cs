using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ZipService.ServiceReference1;

namespace ZipService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        

        // TODO: Add your service operations here
        [OperationContract]
        [WebGet(UriTemplate = "CityStateToZipCodeMatcher/{city}/{state}")]
        object [] CityStateToZipCodeMatcher(string city, string state);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
   
}
