using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;

namespace WhatToWear.Data
{
  public class Clothes
  {
    [PrimaryKey, AutoIncrement]
    public int ID { get; set; }
    public int MinTemp { get; set; }
    public int MaxTemp { get; set; }
    public string Type { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }

    public Clothes()
    {
    }
  }
}
