using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace WhatToWear
{
  public partial class SettingsPage : ContentPage
  {
    public SettingsPage()
    {
      InitializeComponent();
      SettingsView.ItemSelected += (sender, e) => {
        ((ListView)sender).SelectedItem = null;
      };
      SettingsView.ItemsSource = new string[]
      {
        "Your clothes",
        "Add clothes"
      };
    }

    private async void SettingsView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
      if (e.SelectedItem == null) return;
      var item = e.SelectedItem.ToString();
      switch (item)
      {
        case "Your clothes":
          await Navigation.PushModalAsync(new ShowClothesPage());
          break;
        case "Add clothes":
          await Navigation.PushModalAsync(new AddClothesPage());
          break;
      }
    }
  }
}
