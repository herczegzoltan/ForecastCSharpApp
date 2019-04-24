using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace WPFApp.Helpers
{
    public class DarkSkyAPI
    {
        public static HttpClient DarkSkyApiClient { get; set; } = new HttpClient();
        public static void InitializeClient()
        {
            DarkSkyApiClient = new HttpClient();
            DarkSkyApiClient.DefaultRequestHeaders.Accept.Clear();
            DarkSkyApiClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
