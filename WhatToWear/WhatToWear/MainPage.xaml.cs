using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatToWear.Weather;
using Xamarin.Forms;

namespace WhatToWear
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Title = "Saint-Petersburg";
            ShowWeather();
        }

        public async void ShowWeather()
        {
            var weather = await Core.GetWeather("Florida", "us");
            if (weather != null)
            {
                BindingContext = weather;
            }
        }
    }
}
