using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.StoreService;
using Newtonsoft.Json.Linq;
using WebApplication1.findstore;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           /* StoreService.Service1Client store = new StoreService.Service1Client();
            string output=store.getNearestStore(TextBox1.Text,TextBox2.Text);
            Label2.Text = output;*/

            findstore.Service1Client sc = new findstore.Service1Client();
            var data = sc.getNearestStore(TextBox1.Text.ToString(), TextBox2.Text.ToString());

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
                        Label1.Text += i++ + " : " + value + System.Environment.NewLine;
                    //if (name == "phone")
                      //  TextBox1.Text += name + " : " + value + System.Environment.NewLine;

                }
            }
        }
    }
}