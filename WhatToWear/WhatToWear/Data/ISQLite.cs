using SQLite;

namespace WhatToWear.Data
{
  public interface ISQLite
  {
    SQLiteConnection GetConnection();
  }
}