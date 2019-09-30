using barcodeservice.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace Barcocde
{
    public static  class ReadAPI
    {
        public static string ServiceURL { get; set; } = "http://163.44.192.123:8686/api/";

        public static WReportResponse SaveTo(string userID, string reportJson)
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ServiceURL);


                var parameter = new List<KeyValuePair<string, string>>();

                parameter.Add(new KeyValuePair<string, string>("userID", userID));
                parameter.Add(new KeyValuePair<string, string>("reportJson", reportJson));

                var content = new FormUrlEncodedContent(parameter);

                // HTTP POST
                HttpResponseMessage response = client.PostAsync("winform/addreport", content).Result;
                if (response.IsSuccessStatusCode)
                {
                    var retobj = response.Content.ReadAsAsync<WReportResponse>().Result;
                    
                    return retobj;
                }
            }
            return null;
        }
        public static WLoginResponse Login(string username, string password)
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ServiceURL);

                var parameter = new List<KeyValuePair<string, string>>();
                parameter.Add(new KeyValuePair<string, string>("username", username));
                parameter.Add(new KeyValuePair<string, string>("password", password));

                var content = new FormUrlEncodedContent(parameter);

                // HTTP POST
                HttpResponseMessage response = client.PostAsync("winform/login", content).Result;
                if (response.IsSuccessStatusCode)
                {
                    var retobj = response.Content.ReadAsAsync<WLoginResponse>().Result;
                    return retobj;
                }
            }
            return null;
        }

    }
}
