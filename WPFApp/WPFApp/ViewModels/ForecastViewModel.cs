using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFApp.Helpers;

namespace WPFApp.ViewModels
{
    public class ForecastViewModel : ForecastPropertyViewModel
    {
        public ForecastViewModel()
        {
            DarkSkyAPI.InitializeClient();
            AddLangugesToModel();
        }   

        public void AddLangugesToModel()
        {
            Languages.Add(new Models.LanguageModel { KeyLang = "hu", ValueLang = "Hungarian" });
            Languages.Add(new Models.LanguageModel { KeyLang = "be", ValueLang = "Belgian" });
            Languages.Add(new Models.LanguageModel { KeyLang = "en", ValueLang = "English" });
        }
        

 
        public async void GetForecastInformation()
        {
            var forecastInfo = await ForecastProcessor.LoadForecastInformation("47.49801,19.03991", "hu");

            CurrentSummary = forecastInfo.currently.summary;
            CurrentTemperature = forecastInfo.currently.temperature;
            CurrentApparentTemperature = forecastInfo.currently.apparentTemperature;
            CurrentPressure = forecastInfo.currently.pressure;
            CurrentWindSpeed = forecastInfo.currently.windSpeed;
            CurrentHumidity = forecastInfo.currently.humidity;
            CurrentUvIndex = forecastInfo.currently.uvIndex;

        }
    }
}
