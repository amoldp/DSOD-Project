using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Xml;
using Asg5.ServiceReference1;
using Asg5.weather;
using Newtonsoft.Json.Linq;
using Asg5.map;
using System.Net;

namespace Asg5
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String date = DateTime.Now.ToLongDateString();
            String time = DateTime.Now.ToLongTimeString();
            Label1.Text = date + ", " + time;

            HttpCookie myCookies = Request.Cookies["myCookieId"];
            if (myCookies != null)
            {
                Label2.Text = "Welcome back, your city name is " + myCookies["cityName"]+" state name is "+myCookies["stateName"];
            }
        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client1 = new ServiceReference1.Service1Client();
            string output = client1.getNearestStore(TextBox1.Text,TextBox9.Text);
           // TextBox5.Text = output;
            var data = client1.getNearestStore(TextBox1.Text.ToString(), TextBox9.Text.ToString());

            JObject j = JObject.Parse(data);    //parsing the string 
            JArray businesses = (JArray)j.GetValue("businesses");  //taking the array with label 'businesses' out.

            int i = 1;
            foreach (JObject o in businesses.Children<JObject>()) //for loop for displaying the names and contacts of the restaurants.
            {
                foreach (JProperty prop in o.Properties())
                {
                    string name = prop.Name;
                    string value = prop.Value.ToString();
                    if (name == "name")
                       TextBox5.Text += i++ + " : " + value + System.Environment.NewLine;
                    //if (name == "phone")
                    //  TextBox1.Text += name + " : " + value + System.Environment.NewLine;

                }
            }


            string input = TextBox1.Text;
            string url = @"http://localhost:14450/Service1.svc/CityStateToZipCodeMatcher/" + TextBox1.Text.ToString() + "/" + TextBox9.Text.ToString();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader sreader = new StreamReader(dataStream);
            string responsereader = sreader.ReadToEnd();
            response.Close();
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.LoadXml(responsereader);
            XmlNodeList xnList = xmldoc.SelectNodes("/ArrayOfanyType");
            string anyType = "", s = "";
            foreach (XmlNode xn in xnList)
            {
                anyType = xn["anyType"].InnerText.ToString();
                s += anyType+"\t";
            }
            TextBox10.Text = s;


            HttpCookie myCookies = new HttpCookie("myCookieId");
            myCookies["cityName"] = TextBox1.Text;
            myCookies["stateName"] = TextBox9.Text;
            myCookies.Expires = DateTime.Now.AddMonths(6);
            Response.Cookies.Add(myCookies);
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Asg5.weather.Service1Client client2 = new weather.Service1Client();
            string s = client2.getWeather(TextBox7.Text.ToString());
            TextBox8.Text = s;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Asg5.map.Service1Client client3 = new map.Service1Client();
            string s=client3.GetImagery(TextBox1.Text);
            frameid.Attributes.Add("src", s); 
        }
    }
}