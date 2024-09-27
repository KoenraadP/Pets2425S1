using Pets.Dal;
using Pets.Entities;
using System.Collections.Generic;
using System;

namespace Pets.Bll
{
    public static class FoodsBll
    {
        public static bool Create(string name, string description, decimal price,
            int amountInStock, bool inStock, double weight, string selectedBrand)
        {
            Food f = new Food(Guid.NewGuid(), name, description, price,
                amountInStock, AnimalType.Cat,weight, AgeCategory.Adult);
            Guid brandId = Guid.Parse(selectedBrand);
            return FoodsDal.Create(f, brandId);
        }

        public static List<Food> Read()
        {
            return FoodsDal.Read();
        }
    }
}
