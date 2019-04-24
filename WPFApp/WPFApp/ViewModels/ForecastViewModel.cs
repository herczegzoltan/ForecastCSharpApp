using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFApp.Helpers;
using System.IO;


namespace WPFApp.ViewModels
{
    public class ForecastViewModel : ForecastPropertyViewModel
    {
        public ForecastViewModel()
        {
            DarkSkyAPI.InitializeClient();
            AddLangugesToModel();
            AddCitiesToModel();
        }   

        public void AddLangugesToModel()
        {
            string fileName = string.Format(@"Resources\ListOfLanguages.txt");

            var dictOfLangs = File.ReadAllLines(fileName, Encoding.ASCII)
               .Where(line => !string.IsNullOrEmpty(line))
               .Select(line => line.Split(new char[] { ':' }, 2, 0))
               .ToDictionary(parts => parts[0], parts => parts[1]);

            foreach (KeyValuePair<string, string> item in dictOfLangs)
            {
                Languages.Add(new Models.LanguageModel { KeyLang = item.Key, ValueLang = item.Value });
            }

        }

        public void AddCitiesToModel()
        {
            string fileName = string.Format(@"Resources\ListOfCities.txt");

            var dictOfCities = File.ReadAllLines(fileName, Encoding.GetEncoding("iso-8859-1"))
               .Where(line => !string.IsNullOrEmpty(line))
               .Select(line => line.Split(new char[] { ':' }, 2, 0))
               .ToDictionary(parts => parts[0], parts => parts[1]);

            foreach (KeyValuePair<string, string> item in dictOfCities)
            {
                Cities.Add(new Models.CityModel { KeyCity = item.Key, ValueCoord = item.Value });
            }

        }

        public async void GetForecastInformation()
        {
            

            var forecastInfo = await ForecastProcessor.LoadForecastInformation(SelectedCity.ValueCoord, SelectedLanguage.KeyLang);

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
