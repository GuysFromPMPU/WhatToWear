using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WhatToWear.Weather;
using Xamarin.Forms;

namespace WhatToWear
{
  public partial class App : Application
  {
    public App()
    {
            Core.GetWeather();
            InitializeComponent();

      MainPage = new WhatToWear.MainPage();
    }

    protected override void OnStart()
    {
      // Handle when your app starts
    }

    protected override void OnSleep()
    {
      // Handle when your app sleeps
    }

    protected override void OnResume()
    {
      // Handle when your app resumes
    }
  }
}
