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
using WcfService1.USZip;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string citysearch(string input)
        {
            USZip.USZipSoapClient zip = new USZip.USZipSoapClient();
            XmlDocument xmlDoc = new XmlDocument();
            var v = zip.GetInfoByCity(input);
            return v.ToString();
        }
    }
}
