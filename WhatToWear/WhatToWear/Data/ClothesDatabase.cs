using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;

namespace WhatToWear.Data
{
  public partial class ClothesDatabase
  {
    private SQLiteConnection _connection;

    public ClothesDatabase()
    {
      _connection = DependencyService.Get<ISQLite>().GetConnection();
      _connection.CreateTable<Clothes>();
      if (!GetClothes().Any())
      {
        SetupDatabase();
      }
    }

    public IEnumerable<Clothes> GetClothes()
    {
      return (from t in _connection.Table<Clothes>()
              select t).ToList();
    }

    public Clothes GetSingleClothes(int id)
    {
      return _connection.Table<Clothes>().FirstOrDefault();
    }

    public void DeleteClothes(int id)
    {
      _connection.Delete<Clothes>(id);
    }

    public void AddClothes(Clothes newClothes)
    {
      _connection.Insert(newClothes);
    }
  }
}
