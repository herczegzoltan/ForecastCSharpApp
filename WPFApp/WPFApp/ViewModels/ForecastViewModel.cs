﻿using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFApp.Helpers;
using System.IO;
using WPFApp.Models;
using System.Reflection;
using System.Windows.Media.Imaging;

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

            if (SelectedLanguage == null || SelectedCity == null)
            {
                CurrentSummary = "Select Language/City!";
            }
            else
            {

                var forecastInfo = await ForecastProcessor.LoadForecastInformation(SelectedCity.ValueCoord, SelectedLanguage.KeyLang);

                CurrentSummary = forecastInfo.currently.summary;
                CurrentTemperature = forecastInfo.currently.temperature + "°C";
                CurrentApparentTemperature = forecastInfo.currently.apparentTemperature + "°C";
                CurrentPressure = forecastInfo.currently.pressure + "hPa";
                CurrentWindSpeed = forecastInfo.currently.windSpeed + "m/s";
                CurrentHumidity = forecastInfo.currently.humidity;
                CurrentUvIndex = forecastInfo.currently.uvIndex;
                CurrentIcon = @"\Resources\" + forecastInfo.currently.icon + ".png";

                string[] DaysAr = new string[8];
                string[] IconsDay = new string[8];

                for (int i = 0; i < 8; i++)
                {
                    DaysAr[i] =
                        forecastInfo.daily.data[i].summary + "\n" +
                        forecastInfo.daily.data[i].temperatureHigh + "°C" + "\n" +
                        forecastInfo.daily.data[i].temperatureLow + "°C" + "\n" +
                        forecastInfo.daily.data[i].apparentTemperatureHigh + "°C" + "\n" +
                        forecastInfo.daily.data[i].apparentTemperatureLow + "°C" + "\n" +
                        forecastInfo.daily.data[i].pressure + "hPa" + "\n" +
                        forecastInfo.daily.data[i].windSpeed + "m/s" + "\n" +
                        forecastInfo.daily.data[i].humidity + "\n" +
                        forecastInfo.daily.data[i].uvIndex;

                    IconsDay[i] = forecastInfo.daily.data[i].icon;

                }

                Day1 = DaysAr[0];
                Day2 = DaysAr[1];
                Day3 = DaysAr[2];
                Day4 = DaysAr[3];
                Day5 = DaysAr[4];
                Day6 = DaysAr[5];
                Day7 = DaysAr[6];
                Day8 = DaysAr[7];

                IconDay1 = @"\Resources\" + IconsDay[0] + ".png";
                IconDay2 = @"\Resources\" + IconsDay[1] + ".png";
                IconDay3 = @"\Resources\" + IconsDay[2] + ".png";
                IconDay4 = @"\Resources\" + IconsDay[3] + ".png";
                IconDay5 = @"\Resources\" + IconsDay[4] + ".png";
                IconDay6 = @"\Resources\" + IconsDay[5] + ".png";
                IconDay7 = @"\Resources\" + IconsDay[6] + ".png";
                IconDay8 = @"\Resources\" + IconsDay[7] + ".png";

            }
        }
    }
}
