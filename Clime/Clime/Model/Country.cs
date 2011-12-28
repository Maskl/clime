using System;
using System.Windows;

namespace Clime.Model
{
    class Country : DependencyObject
    {
        public Country(ContinentsEnum continentId, string countryCode, string name, string flagImageUrl)
        {
            ContinentId = continentId;
            CountryCode = countryCode;
            Name = name;
            FlagImageUrl = flagImageUrl;
        }

        public ContinentsEnum ContinentId { get; private set; }
        public string Name { get; private set; }
        public string CountryCode { get; private set; }
        
        private string _flagImageUrl;
        public string FlagImageUrl
        {
            get { return "/Clime;component/Img/Flags/" + _flagImageUrl; }
            private set { _flagImageUrl = value; }
        }
    }
}

