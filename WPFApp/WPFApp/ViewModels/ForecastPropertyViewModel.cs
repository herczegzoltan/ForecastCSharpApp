using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFApp.Models;

namespace WPFApp.ViewModels
{
    public class ForecastPropertyViewModel : Screen
    {

        private string _CurrentSummary;
        private string _CurrentTemperature;
        private string _CurrentApparentTemperature;
        private string _CurrentPressure;
        private string _CurrentWindSpeed;
        private string _CurrentHumidity;
        private string _CurrentUvIndex;

        private string _DailySummary;

        public string DailySummary
        {
            get
            {
                return _DailySummary;
            }
            set
            {
                _DailySummary = value;
                NotifyOfPropertyChange(() => DailySummary);
            }
        }


        private BindableCollection<LanguageModel> _language = new BindableCollection<LanguageModel>();
        private LanguageModel _selectedLanguage;

        private BindableCollection<CityModel> _city = new BindableCollection<CityModel>();
        private CityModel _selectedCity;

        public string CurrentSummary
        {
            get
            {
                return _CurrentSummary;
            }
            set
            {
                _CurrentSummary = value;
                NotifyOfPropertyChange(() => CurrentSummary);
            }
        }
        public string CurrentTemperature
        {
            get
            {
                return _CurrentTemperature;
            }
            set
            {
                _CurrentTemperature = value;

                NotifyOfPropertyChange(() => CurrentTemperature);
            }
        }
        public string CurrentApparentTemperature
        {
            get
            {
                return _CurrentApparentTemperature;
            }
            set
            {
                _CurrentApparentTemperature = value;

                NotifyOfPropertyChange(() => CurrentApparentTemperature);
            }
        }
        public string CurrentPressure
        {
            get
            {
                return _CurrentPressure;
            }
            set
            {
                _CurrentPressure = value;

                NotifyOfPropertyChange(() => CurrentPressure);
            }
        }
        public string CurrentWindSpeed
        {
            get
            {
                return _CurrentWindSpeed;
            }
            set
            {
                _CurrentWindSpeed = value;

                NotifyOfPropertyChange(() => CurrentWindSpeed);
            }
        }
        public string CurrentHumidity
        {
            get
            {
                return _CurrentHumidity;
            }
            set
            {
                _CurrentHumidity = value;

                NotifyOfPropertyChange(() => CurrentHumidity);
            }
        }
        public string CurrentUvIndex
        {
            get
            {
                return _CurrentUvIndex;
            }
            set
            {
                _CurrentUvIndex = value;

                NotifyOfPropertyChange(() => CurrentUvIndex);
            }
        }

        public BindableCollection<LanguageModel> Languages
        {
            get { return _language; }
            set { _language = value; }
        }

        public LanguageModel SelectedLanguage
        {
            get { return _selectedLanguage; }
            set
            {
                _selectedLanguage = value;
                NotifyOfPropertyChange(() => SelectedLanguage);
            }
        }

        public BindableCollection<CityModel> Cities
        {
            get { return _city; }
            set { _city = value; }
        }
        public CityModel SelectedCity
        {
            get { return _selectedCity; }
            set
            {
                _selectedCity = value;
                NotifyOfPropertyChange(() => SelectedCity);
            }
        }

    }
}
