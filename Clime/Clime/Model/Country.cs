using System;
using System.Windows;

namespace Clime.Model
{
    public class Country : DependencyObject
    {
        public Country(string countryCode, string name, string flagImageUrl)
        {
            CountryCode = countryCode;
            Name = name;
            FlagImageUrl = flagImageUrl;
        }

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

