using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using WhatToWear.Data;
using WhatToWear.Weather;
using Xamarin.Forms;

namespace WhatToWear
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            ClothesDatabase database = new ClothesDatabase();
            var clothes = database.GetClothes();
            Debug.WriteLine(clothes.FirstOrDefault().Name);
            Debug.WriteLine(clothes.Count());
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
