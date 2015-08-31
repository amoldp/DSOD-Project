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
using System.Configuration; 
using System.Web.Services;
using OAuth;


namespace NearestStore
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        /*
        {
            // string url = @"http://api.yelp.com/v2/search?term=" +
            //       place + "&location=" + location ;
            string url = @"http://api.yelp.com/v2/search?term=cream+puffs&location=San+Francisco";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader sreader = new StreamReader(dataStream);
            string responsereader = sreader.ReadToEnd();
            response.Close();

            XmlDocument xmldoc = new XmlDocument();
            xmldoc.LoadXml(responsereader);

            /*
            if (xmldoc.GetElementsByTagName("status")[0].ChildNodes[0].InnerText == "OK")
            {
                XmlNodeList distance = xmldoc.GetElementsByTagName("distance");
                return Convert.ToDouble(distance[0].ChildNodes[1].InnerText.Replace(" mi", ""));
            }
             */
        /*
            string s = xmldoc.ToString();

            return s;
        */
        public string oauthConsumerKey;
	public string oauthConsumerSecret;
	public string oauthToken;
	public string oauthTokenSecret;
	
	
	
	// Help formatting the request: http://stackoverflow.com/questions/6036934/accessing-yelps-oauth-1-0a-api-with-dotnetopenauth
	public string getNearestStore(string place,string location)
	{
		
		
		//string yelpSearchUrl = "http://api.yelp.com/v2/search?" + 
        //"term=" + place + "&location=" + location;
		

        /*
		string formattedUri = String.Format(System.Globalization.CultureInfo.InvariantCulture, yelpSearchUrl, "");
		Uri urlUri = new Uri(formattedUri);
		string outNormalisedUrl = "";
		string outNormalisedRequestParameters = "";
		
		OAuth.OAuthBase oauthBase = new OAuth.OAuthBase();
		string oauthSignature = oauthBase.GenerateSignature(
			urlUri, 
			oauthConsumerKey, 
			oauthConsumerSecret, 
			oauthToken, 
			oauthTokenSecret, 
			"GET", 
			oauthBase.GenerateTimeStamp(), 
			oauthBase.GenerateNonce(), 
			out outNormalisedUrl, 
			out outNormalisedRequestParameters);
		
		string urlString = outNormalisedUrl + "?" + outNormalisedRequestParameters + 
			"&oauth_signature=" + oauthSignature;
		*/
                    OAuth.OAuthBase oA = new OAuth.OAuthBase(); //authorization class object

            var _url = String.Format("http://api.yelp.com/v2/search?term={0}&location={1}&limit=10&category_filter=food", place, location); //URL for calling RESTful api for yelp.
            string parameters, out_url;
            Uri uri = new Uri(_url);
            //authorizing the request
            var signature = oA.GenerateSignature(uri,
                                    ConfigurationManager.AppSettings["YelpConsumerKey"],
                                    ConfigurationManager.AppSettings["YelpConsumerSecret"],
                                    ConfigurationManager.AppSettings["YelpToken"],
                                    ConfigurationManager.AppSettings["YelpTokenSecret"],
                                    "GET",
                                    oA.GenerateTimeStamp(),
                                    oA.GenerateNonce(),
                                    OAuth.OAuthBase.SignatureTypes.HMACSHA1,
                                    out out_url,
                                    out parameters
                                    );
            var newURL = string.Format("{0}?{1}&oauth_signature={2}", out_url, parameters, HttpUtility.UrlEncode(signature));
            var req = WebRequest.Create(newURL) as HttpWebRequest;
            var response = req.GetResponse();


            var reader = new StreamReader(response.GetResponseStream()); //JSON output
            var data = reader.ReadToEnd(); //converting to string
            return data;
		
		
		
	}
        }
    }
