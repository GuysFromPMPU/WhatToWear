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
            var clothesList = new List<Clothes>
            {
                new Clothes {Type = "headwear", Name = "wool-hat", Gender = "unisex", MinTemp = -100, MaxTemp = 5},
                new Clothes {Type = "headwear", Name = "big-hat", Gender = "male", MinTemp = 5, MaxTemp = 25},
                new Clothes {Type = "headwear", Name = "woman-hat", Gender = "female", MinTemp = 5, MaxTemp = 30 },

                new Clothes {Type = "outerwear", Name = "shirt-2", Gender = "unisex", MinTemp = 20, MaxTemp = 100},
                new Clothes {Type = "outerwear", Name = "short-sleeve-t-shirt", Gender = "unisex", MinTemp = 20, MaxTemp = 100},
                new Clothes {Type = "outerwear", Name = "shirt-5", Gender = "unisex", MinTemp = 15, MaxTemp = 100},
                new Clothes {Type = "outerwear", Name = "sweater-with-hood", Gender = "male", MinTemp = 10, MaxTemp = 20},
                new Clothes {Type = "outerwear", Name = "shirt-with-vest", Gender = "male", MinTemp = 10, MaxTemp = 25}



            };

            foreach (var clothes in clothesList)
            {
                clothes.Color = "black";
                AddClothes(clothes);
            }
        }
    }
}
