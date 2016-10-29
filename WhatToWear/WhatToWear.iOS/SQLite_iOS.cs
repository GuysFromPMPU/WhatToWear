using System;
using System.IO;
using SQLite;
using WhatToWear.Data;
using WhatToWear.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: Dependency(typeof(SQLite_iOS))]

namespace WhatToWear.iOS
{
  public class SQLite_iOS : ISQLite
  {
    public SQLite_iOS()
    {
    }

    #region ISQLite implementation

    SQLiteConnection ISQLite.GetConnection()
    {
      var fileName = "Clothes.db3";
      var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
      var libraryPath = Path.Combine(documentsPath, "..", "Library");
      var path = Path.Combine(libraryPath, fileName);
      var connection = new SQLite.SQLiteConnection(path);
      return connection;
    }

    #endregion
  }
}