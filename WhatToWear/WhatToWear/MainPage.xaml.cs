using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatToWear.Data;
using WhatToWear.Weather;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WhatToWear
{
  public partial class MainPage : ContentPage
  {


    public MainPage()
    {
      NavigationPage.SetHasNavigationBar(this, false);

      InitializeComponent();
      ShowWeather();
    }
    public static List<Clothes> list1 = new List<Clothes>();
    public static List<Clothes> list2 = new List<Clothes>();
    public static List<Clothes> list3 = new List<Clothes>();
    public static List<Clothes> list4 = new List<Clothes>();
    public static List<Clothes> list5 = new List<Clothes>();
    public static List<Clothes> list6 = new List<Clothes>();
    public static List<Clothes> list7 = new List<Clothes>();

    public void randomClothes()
    {
      Random rand = new Random();
      var currentclothe = list1[rand.Next(list1.Count)];
      Debug.WriteLine(currentclothe.Name);
      Image1.Source = ImageSource.FromResource("WhatToWear.Resources." + currentclothe.Type + "." + currentclothe.Name.Replace(" ", "-").ToLower() + "." + currentclothe.Color + ".png");
      Debug.WriteLine("Resources.headwear." + currentclothe.Name.Replace(" ", "-").ToLower() + "." + currentclothe.Color + ".png");
      currentclothe = list2[rand.Next(list2.Count)];
      Debug.WriteLine(currentclothe.Name);
      Image2.Source = ImageSource.FromResource("WhatToWear.Resources." + currentclothe.Type + "." + currentclothe.Name.Replace(" ", "-").ToLower() + "." + currentclothe.Color + ".png");

      currentclothe = list3[rand.Next(list3.Count)];
      Debug.WriteLine(currentclothe.Name);
      Image3.Source = ImageSource.FromResource("WhatToWear.Resources." + currentclothe.Type + "." + currentclothe.Name.Replace(" ", "-").ToLower() + "." + currentclothe.Color + ".png");

      currentclothe = list4[rand.Next(list4.Count)];
      Debug.WriteLine(currentclothe.Name);
      Image4.Source = ImageSource.FromResource("WhatToWear.Resources." + currentclothe.Type + "." + currentclothe.Name.Replace(" ", "-").ToLower() + "." + currentclothe.Color + ".png");

      currentclothe = list5[rand.Next(list5.Count)];
      Debug.WriteLine(currentclothe.Name);
      Image5.Source = ImageSource.FromResource("WhatToWear.Resources." + currentclothe.Type + "." + currentclothe.Name.Replace(" ", "-").ToLower() + "." + currentclothe.Color + ".png");

      if (list6.Count > 0)
      {
        currentclothe = list6[rand.Next(list6.Count)];
        Image6.Source = ImageSource.FromResource("WhatToWear.Resources." + currentclothe.Type + "." +
                                   currentclothe.Name.Replace(" ", "-").ToLower() + "." + currentclothe.Color + ".png");
      }
      if (list7.Count > 0)
      {
        currentclothe = list7[rand.Next(list7.Count)];
        Image7.Source = ImageSource.FromResource("WhatToWear.Resources." + currentclothe.Type + "." + 
          currentclothe.Name.Replace(" ", "-").ToLower() + "." + currentclothe.Color + ".png");
      }
    }
    public async void ShowWeather()
    {
      var weather = await Core.GetWeather(WhatToWear.App.query);
      switch (weather.Icon)
      {
        case "10d":
          imageBackground.Source = ImageSource.FromResource("WhatToWear.Resources.Images.background_rain.jpg");
          break;
        default:
          imageBackground.Source = ImageSource.FromResource("WhatToWear.Resources.Images.background_sunny.jpg");
          break;
      }
      var clothes = WhatToWear.App.database.GetClothes();
      var buffTemperature = weather.Temperature.Remove(weather.Temperature.Length - 2, 2);
      Debug.WriteLine(weather.Temperature);
      var degrees = Convert.ToDouble(buffTemperature);
      switch (WhatToWear.App.query.Format)
      {
        case "imperial":
          degrees = Convert.ToDouble(degrees - 32) * 5.0 / 9.0;
          break;
      }
      list1.Clear(); list2.Clear(); list3.Clear(); list4.Clear(); list5.Clear(); list6.Clear(); list7.Clear();
      foreach (var clothe in clothes)
      {
        if (degrees >= Convert.ToDouble(clothe.MinTemp) && degrees <= Convert.ToDouble(clothe.MaxTemp))
        {
          switch (clothe.Type)
          {
            case "headwear":
              list1.Add(clothe);
              break;
            case "sweater":
              list2.Add(clothe);
              break;
            case "jacket":
              list3.Add(clothe);
              break;
            case "pants":
              list4.Add(clothe);
              break;
            case "footwear":
              list5.Add(clothe);
              break;
            case "other":
              {
                if (clothe.Name == "Umbrella")
                {
                  if (weather.Icon == "10d")
                    list6.Add(clothe);
                }
                else
                  list7.Add(clothe);
              }
              break;
          }
        }
      }
      randomClothes();
      if (weather != null)
      {
        BindingContext = weather;
      }
    }

    private async void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
    {
      await Navigation.PushModalAsync(new SettingsPage());
    }

    private void I_Want_More_OnClicked(object sender, EventArgs e)
    {
      randomClothes();
      this.ForceLayout();
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
