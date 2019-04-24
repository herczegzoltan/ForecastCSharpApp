using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApp.ViewModels
{
    public class ForecastProperty : Screen
    {

        private string _CurrentSummary;
        private string _CurrentTemperature;
        private string _CurrentApparentTemperature;
        private string _CurrentPressure;
        private string _CurrentWindSpeed;
        private string _CurrentHumidity;
        private string _CurrentUvIndex;
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





    }
}
