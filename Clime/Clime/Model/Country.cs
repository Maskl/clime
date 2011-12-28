using System;
using System.Windows;

namespace Clime.Model
{
    public class Country : DependencyObject
    {
        public Country(string countryCode, string name, string flagImageUrl)
        {
            CountryCode = countryCode;
            Name = Name;
            FlagImageUrl = flagImageUrl;
        }

        public string Name { get { return (string)GetValue(TitleProperty); } set { SetValue(TitleProperty, value); } }
        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(Country), new UIPropertyMetadata(""));

        private string _countryCode = "fsdgf";
        public string CountryCode
        {
            get { return "aaa"; }
            set { _countryCode = value + "jj"; }
        }
      //  public string Name { get; private set; }
        public string FlagImageUrl { get; private set; }
    }
}

