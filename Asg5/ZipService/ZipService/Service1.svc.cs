using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web;
using System.Net;
using System.IO;
using System.Xml;
using ZipService.ServiceReference2;


namespace ZipService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public object [] CityStateToZipCodeMatcher(string city, string state)
        {
           
            ServiceReference2.AddressLookupSoapClient zip = new ServiceReference2.AddressLookupSoapClient();
            XmlDocument xmlDoc = new XmlDocument();
           
             object [] o= zip.CityStateToZipCodeMatcher(city, state,true,"0");
             return o;
        }
        
    }
}
