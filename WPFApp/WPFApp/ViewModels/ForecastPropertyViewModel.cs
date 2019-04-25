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
        private string _CurrentIcon;


        private string _Day1;
        private string _Day2;
        private string _Day3;
        private string _Day4;
        private string _Day5;
        private string _Day6;
        private string _Day7;
        private string _Day8;

        private string _IconDay1;
        private string _IconDay2;
        private string _IconDay3;
        private string _IconDay4;
        private string _IconDay5;
        private string _IconDay6;
        private string _IconDay7;
        private string _IconDay8;



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
        public string CurrentIcon
        {
            get
            {
                return _CurrentIcon;
            }
            set
            {
                _CurrentIcon = value;

                NotifyOfPropertyChange(() => CurrentIcon);
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

        public string Day1
        {
            get
            {
                return _Day1;
            }
            set
            {
                _Day1 = value;
                NotifyOfPropertyChange(() => Day1);
            }
        }
        public string Day2
        {
            get
            {
                return _Day2;
            }
            set
            {
                _Day2 = value;
                NotifyOfPropertyChange(() => Day2);
            }
        }
        public string Day3
        {
            get
            {
                return _Day3;
            }
            set
            {
                _Day3 = value;
                NotifyOfPropertyChange(() => Day3);
            }
        }
        public string Day4
        {
            get
            {
                return _Day4;
            }
            set
            {
                _Day4 = value;
                NotifyOfPropertyChange(() => Day4);
            }
        }
        public string Day5
        {
            get
            {
                return _Day5;
            }
            set
            {
                _Day5 = value;
                NotifyOfPropertyChange(() => Day5);
            }
        }
        public string Day6
        {
            get
            {
                return _Day6;
            }
            set
            {
                _Day6 = value;
                NotifyOfPropertyChange(() => Day6);
            }
        }
        public string Day7
        {
            get
            {
                return _Day7;
            }
            set
            {
                _Day7 = value;
                NotifyOfPropertyChange(() => Day7);
            }
        }
        public string Day8
        {
            get
            {
                return _Day8;
            }
            set
            {
                _Day8 = value;
                NotifyOfPropertyChange(() => Day8);
            }
        }

        public string IconDay1
        {
            get
            {
                return _IconDay1;
            }
            set
            {
                _IconDay1 = value;
                NotifyOfPropertyChange(() => IconDay1);
            }
        }
        public string IconDay2
        {
            get
            {
                return _IconDay2;
            }
            set
            {
                _IconDay2 = value;
                NotifyOfPropertyChange(() => IconDay2);
            }
        }
        public string IconDay3
        {
            get
            {
                return _IconDay3;
            }
            set
            {
                _IconDay3 = value;
                NotifyOfPropertyChange(() => IconDay3);
            }
        }
        public string IconDay4
        {
            get
            {
                return _IconDay4;
            }
            set
            {
                _IconDay4 = value;
                NotifyOfPropertyChange(() => IconDay4);
            }
        }
        public string IconDay5
        {
            get
            {
                return _IconDay5;
            }
            set
            {
                _IconDay5 = value;
                NotifyOfPropertyChange(() => IconDay5);
            }
        }
        public string IconDay6
        {
            get
            {
                return _IconDay6;
            }
            set
            {
                _IconDay6 = value;
                NotifyOfPropertyChange(() => IconDay6);
            }
        }
        public string IconDay7
        {
            get
            {
                return _IconDay7;
            }
            set
            {
                _IconDay7 = value;
                NotifyOfPropertyChange(() => IconDay7);
            }
        }
        public string IconDay8
        {
            get
            {
                return _IconDay8;
            }
            set
            {
                _IconDay8 = value;
                NotifyOfPropertyChange(() => IconDay8);
            }
        }

    }
}
