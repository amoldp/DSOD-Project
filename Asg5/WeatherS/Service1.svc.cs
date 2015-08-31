using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using WeatherS.ServiceReference1;

namespace WeatherS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string getWeather(string zip)
        {
            WeatherS.ServiceReference1.WeatherSoapClient w = new WeatherS.ServiceReference1.WeatherSoapClient();
            //var v=w.GetCityForecastByZIP(TextBox1.Text);
            XmlDocument xmlDoc = new XmlDocument();
           
            ForecastReturn fr = w.GetCityForecastByZIP(zip);
            string s = "";
            for (int i = 0; i < fr.ForecastResult.Length; i++)
            {
                s += "Date " + fr.ForecastResult.ElementAt(i).Date.ToString() + "<br/>";
                s += "weatherID " + fr.ForecastResult.ElementAt(i).WeatherID.ToString() + "<br/>";
                s += "Description " + fr.ForecastResult.ElementAt(i).Desciption.ToString() + "<br/>";
                s += "Temperatures" + " Morning Low " + fr.ForecastResult.ElementAt(i).Temperatures.MorningLow.ToString() + "\t" + "Daytime High " + fr.ForecastResult.ElementAt(i).Temperatures.DaytimeHigh.ToString() + "<br/>";
                s += "Probability of Precipitation " + "Nighttime " + fr.ForecastResult.ElementAt(i).ProbabilityOfPrecipiation.Nighttime.ToString() + "\t" + " Daytime " + fr.ForecastResult.ElementAt(i).ProbabilityOfPrecipiation.Daytime.ToString() + "<br/>";
            }
            string s1 = "State= " + fr.State + "\n" + "City= " + fr.City + "\n" + "Weather Station City=" + fr.WeatherStationCity + "\n" + s;
            return s1;
        }
    }
}
