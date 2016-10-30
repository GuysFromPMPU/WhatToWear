namespace WhatToWear
{
  public class Query
  {
    public string City { get; set; }
    public string Country { get; set; }
    public string Format { get; set; }

    public Query(string city = "Saint Petersburg", string format = "metric", string country = "ru")
    {
      City = city;
      Format = format;
      Country = country;

    }
  }
}