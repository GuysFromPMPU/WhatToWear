using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatToWear.Weather;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WhatToWear
{
  public partial class MainPage : ContentPage
  {
    public MainPage()
    {
      InitializeComponent();
      ShowWeather();
    }

    public async void ShowWeather()
    {
      var weather = await Core.GetWeather();
      if (weather != null)
      {
        BindingContext = weather;
      }
    }
  }


  [ContentProperty("Source")]
  public class ImageResourceExtension : IMarkupExtension
  {
    public string Source { get; set; }

    public object ProvideValue(IServiceProvider serviceProvider)
    {
      if (Source == null)
      {
        return null;
      }
      // Do your translation lookup here, using whatever method you require
      var imageSource = ImageSource.FromResource(Source);

      return imageSource;
    }
  }
}
