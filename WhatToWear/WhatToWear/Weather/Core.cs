﻿using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace WhatToWear.Weather
{
    public class Core
    {
        public static async Task<Weather> GetWeather(string city = "Saint Petersburg", string country = "ru")
        {
            string queryString = "http://api.openweathermap.org/data/2.5/weather?q="
                + city + ',' + country + "&appid=" + Constants.Key;

            var results = await DataService.getDataFromService(queryString).ConfigureAwait(false);

            if (results["weather"] != null)
            {
                Debug.WriteLine(results["weather"]);
                Weather weather = new Weather();
                weather.Title = (string)results["name"];
                weather.Temperature = (string)results["main"]["temp"] + " F";
                weather.Wind = (string)results["wind"]["speed"] + " mph";
                weather.Humidity = (string)results["main"]["humidity"] + " %";
                weather.Visibility = (string)results["weather"][0]["main"];

                DateTime time = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
                DateTime sunrise = time.AddSeconds((double)results["sys"]["sunrise"]);
                DateTime sunset = time.AddSeconds((double)results["sys"]["sunset"]);
                weather.Sunrise = sunrise.ToString() + " UTC";
                weather.Sunset = sunset.ToString() + " UTC";
                return weather;
            }
            else
            {
                return null;
            }
        }
    }
}