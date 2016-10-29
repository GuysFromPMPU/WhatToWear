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
      AddClothes(new Clothes {
        MinTemp = 20,
        MaxTemp = 280,
        Color = "White",
        Name = "Usual T-shirt Fucking Twice",
        Type = "T-shirt",
      });
    }
  }
}
