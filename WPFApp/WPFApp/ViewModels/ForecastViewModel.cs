using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFApp.Helpers;

namespace WPFApp.ViewModels
{
    public class ForecastViewModel : Screen
    {
        public ForecastViewModel()
        {
            DarkSkyAPI.InitializeClient();
        }

        public async void GetForecastInformation()
        {
            var forecastInfo = await ForecastProcessor.LoadForecastInformation("47.49801,19.03991", "hu");

            //forecastInfo.currently.summary;
        }


    }
}
