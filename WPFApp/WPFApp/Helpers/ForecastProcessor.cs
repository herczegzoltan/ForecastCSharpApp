using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using WPFApp.Models;

namespace WPFApp.Helpers
{
    public class ForecastProcessor
    {
        public static async Task<RootObject> LoadForecastInformation(string latitudeAndLongitude, string language)
        {
            string url = $"https://api.darksky.net/forecast/2fcabea5d1b6cd5c9aee4d570d4b1ae0/{ latitudeAndLongitude}?lang={language}&units=auto";
            using (HttpResponseMessage responseMessage = await DarkSkyAPI.DarkSkyApiClient.GetAsync(url))
            {
                if (responseMessage.IsSuccessStatusCode)
                {
                    RootObject result = await responseMessage.Content.ReadAsAsync<RootObject>();
                    return result;
                }
                else
                {
                    throw new Exception(responseMessage.ReasonPhrase);
                }
            }
        }
    }
}
