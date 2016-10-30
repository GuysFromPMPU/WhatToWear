using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WhatToWear.Data
{
  partial class ClothesDatabase
  {
    public void SetupDatabase()
    {
      //Name.Replace(" ", "-").ToLower() + color + ".png";
      var clothesList = new List<Clothes>
            {
                new Clothes {Type = "headwear", Name = "Wool hat", Gender = "unisex", MinTemp = -100, MaxTemp = 10},
                new Clothes {Type = "headwear", Name = "Big hat", Gender = "male", MinTemp = 0, MaxTemp = 100},
                new Clothes {Type = "headwear", Name = "Woman hat", Gender = "female", MinTemp = 5, MaxTemp = 30 },

                new Clothes {Type = "sweater", Name = "T-shirt", Gender = "unisex", MinTemp = 20, MaxTemp = 100},
                new Clothes {Type = "sweater", Name = "Short sleeve T-shirt", Gender = "unisex", MinTemp = 20, MaxTemp = 100},
                new Clothes {Type = "sweater", Name = "Sweater", Gender = "unisex", MinTemp = -5, MaxTemp = 25},
                new Clothes {Type = "sweater", Name = "Sweater with hood", Gender = "male", MinTemp = -100, MaxTemp = 20},
                new Clothes {Type = "sweater", Name = "Shirt with vest", Gender = "male", MinTemp = -100, MaxTemp = 20},

                new Clothes {Type = "jacket", Name = "Warm anorak", Gender = "unisex", MinTemp = -100, MaxTemp = -5},
                new Clothes {Type = "jacket", Name = "Jacket", Gender = "unisex", MinTemp = -15, MaxTemp = 15},
                new Clothes {Type = "jacket", Name = "Men coat", Gender = "male", MinTemp = -5, MaxTemp = 15},
                new Clothes {Type = "jacket", Name = "Men jacket", Gender = "male", MinTemp = -5, MaxTemp = 15},
                new Clothes {Type = "jacket", Name = "Sport jacket", Gender = "male", MinTemp = 0, MaxTemp = 100},
                new Clothes {Type = "jacket", Name = "Parka", Gender = "unisex", MinTemp = -100, MaxTemp = 15},

                new Clothes {Type = "pants", Name = "Shorts with belt", Gender = "male", MinTemp = 20, MaxTemp = 100},
                new Clothes {Type = "pants", Name = "Shorts", Gender = "male", MinTemp = 20, MaxTemp = 100},
                new Clothes {Type = "pants", Name = "Jeans", Gender = "unisex", MinTemp = -100, MaxTemp = 25},
                new Clothes {Type = "pants", Name = "Sweatpants", Gender = "male", MinTemp = -100, MaxTemp = 25},
                new Clothes {Type = "pants", Name = "Trousers", Gender = "male", MinTemp = -100, MaxTemp = 25},

                new Clothes {Type = "footwear", Name = "Shoes", Gender = "male", MinTemp = 0, MaxTemp = 100},
                new Clothes {Type = "footwear", Name = "Sneakers", Gender = "unisex", MinTemp = -10, MaxTemp = 100},
                new Clothes {Type = "footwear", Name = "Warm boots", Gender = "unisex", MinTemp = -100, MaxTemp = 10},

                new Clothes {Type = "other", Name = "Gloves", Gender = "unisex", MinTemp = -100, MaxTemp = 7},
                new Clothes {Type = "other", Name = "Umbrella", Gender = "unisex", MinTemp = -100, MaxTemp = 100}
            };

      foreach (var clothes in clothesList)
      {
        clothes.Color = "black";
        AddClothes(clothes);
        clothes.Color = "red";
        AddClothes(clothes);
        clothes.Color = "green";
        AddClothes(clothes);
        clothes.Color = "blue";
        AddClothes(clothes);
        clothes.Color = "yellow";
        AddClothes(clothes);
      }
    }
  }
}
