using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace WhatToWear
{
  public partial class ShowClothesPage : ContentPage
  {

    public class Item
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
      Group group = new Group("", "1");
      groupedItems.Add(group);

      // Repeat for each item in a group. This builds the second-level collections
      Item item = new Item("First Item", "First Item Description");
      group.Add(item);


      InitializeComponent();
      GroupedView.ItemsSource = groupedItems;
      GroupedView.ItemSelected += (sender, e) => {
        ((ListView)sender).SelectedItem = null;
      };
    }

    private void SettingsView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
      throw new NotImplementedException();
    }
  }
}
