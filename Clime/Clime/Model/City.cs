using System;
using System.Windows;

namespace Clime.Model
{
    class City : DependencyObject
    {
        private static Random random = new Random();
        public City(string countryCode, string name, string countryFlagImageUrl)
        {
            CountryCode = countryCode;
            CountryFlagImageUrl = countryFlagImageUrl;
            Name = name;

            TemperatureMin = 666;
            TemperatureMax = 666;
            TemperatureAvg = 666;
            CloudinessAvg = 666;

            GenerateRandomWeatherValues();
        }

        public void GenerateRandomWeatherValues()
        {
            TemperatureMin = random.Next(-40, 10);
            TemperatureMax = random.Next(11, 40);
            TemperatureAvg = random.Next(TemperatureMin, TemperatureMax);
            CloudinessAvg = random.Next(5);
        }

        public string Name { get; private set; }
        public string CountryCode { get; private set; }
        public string CountryFlagImageUrl { get; private set; }
        public int TemperatureMin { get; private set; }
        public int TemperatureMax { get; private set; }
        public int TemperatureAvg { get; private set; }
        public int CloudinessAvg { get; private set; }

        public string TemperatureDescription
        {
            get { return String.Format("Avg {0}°C, from {1}°C to {2}°C", TemperatureAvg, TemperatureMin, TemperatureMax); }
        }
    }
}

