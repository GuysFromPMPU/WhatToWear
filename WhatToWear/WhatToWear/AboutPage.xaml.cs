using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace WhatToWear
{
  public partial class AboutPage : ContentPage
  {
    public AboutPage()
    {
      InitializeComponent();
      BindingContext = WhatToWear.App.query;
    }


    private void SaveChanges_OnClicked(object sender, EventArgs e)
    {
      WhatToWear.App.query.City = City.Text;
      WhatToWear.App.query.Country = Country.Text;
      switch (format.SelectedIndex)
      {
        case 1:
          WhatToWear.App.query.Format = "imperial";
          break;
        default:
          WhatToWear.App.query.Format = "metric";
          break;
      }
      Navigation.PushModalAsync(new MainPage());
    }
  }
}
