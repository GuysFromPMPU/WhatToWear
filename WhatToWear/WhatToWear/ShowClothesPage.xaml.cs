using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatToWear.Data;
using Xamarin.Forms;

namespace WhatToWear
{
  public partial class ShowClothesPage : ContentPage
  {

    public class Item:MenuItem
    {
      public String Title { get; private set; }
      public String Description { get; private set; }

      public Item(String title, String description)
      {
        Title = title;
        Description = description;
      }

      // Whatever other properties
    }

    public class Group : ObservableCollection<Item>
    {
      public String Name { get; private set; }
      public String ShortName { get; private set; }

      public Group(String Name, String ShortName)
      {
        this.Name = Name;
        this.ShortName = ShortName;
      }

      // Whatever other properties
    }

    public ShowClothesPage()
    {
      ObservableCollection<Group> groupedItems = new ObservableCollection<Group>();
      Group group = new Group("Headwear", "1");
      groupedItems.Add(group);
      var clothes = WhatToWear.App.database.GetClothes();
      foreach (var clotheSingle in clothes)
      {
        if (clotheSingle.Type.Equals("headwear"))
          group.Add(new Item(clotheSingle.Name, clotheSingle.Color));
      }
      group = new Group("Outerwear", "2");
      groupedItems.Add(group);
      foreach (var clotheSingle in clothes)
      {
        if (clotheSingle.Type.Equals("outerwear"))
          group.Add(new Item(clotheSingle.Name, clotheSingle.Color));
      }
      group = new Group("Jacket", "3");
      groupedItems.Add(group);
      foreach (var clotheSingle in clothes)
      {
        if (clotheSingle.Type.Equals("jacket"))
          group.Add(new Item(clotheSingle.Name, clotheSingle.Color));
      }

      // Repeat for each item in a group. This builds the second-level collections


      InitializeComponent();
      GroupedView.ItemsSource = groupedItems;
      GroupedView.ItemSelected += (sender, e) => {
        ((ListView) sender).SelectedItem = null;
      };
    }

    private void SettingsView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
      throw new NotImplementedException();
    }

    private void MenuItem_OnClicked(object sender, EventArgs e)
    {

      var item = ((Item) sender);
      switch (item.Title)
      {

      }
    }

    private void MenuItem_OnClickedDelete(object sender, EventArgs e)
    {
     ;
      var item = (Item)((MenuItem) sender).CommandParameter;
      
      var clothes = WhatToWear.App.database.GetClothes();
      foreach (var clotheSingle in clothes)
      {
        if (clotheSingle.Name.Equals(item.Title))
        {
          WhatToWear.App.database.DeleteClothes(clotheSingle.ID);
        }
      }
    }
  }
}
