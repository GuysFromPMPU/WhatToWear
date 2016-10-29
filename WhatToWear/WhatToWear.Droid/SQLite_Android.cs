using System;
using System.IO;
using WhatToWear.Data;
using Xamarin.Forms;
using WhatToWear.Droid;

[assembly: Dependency(typeof(SQLite_Android))]

namespace WhatToWear.Droid
{
  public class SQLite_Android: ISQLite
  {
    public SQLite_Android()
    {
    }

    #region ISQLite implementation

    public SQLite.SQLiteConnection GetConnection()
    {
      var fileName = "Clothes.db3";
      var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
      var path = Path.Combine(documentsPath, fileName);
      var connection = new SQLite.SQLiteConnection(path);
      return connection;
    }

    #endregion
  }
}