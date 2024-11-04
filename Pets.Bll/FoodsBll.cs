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
            // Brand id string omzetten naar Guid
            Guid brandId = Guid.Parse(selectedBrand);
            // Brand Guid id meegeven naar Dal Create methode
            return FoodsDal.Create(f, brandId);
        }

        public static List<Food> Read()
        {
            return FoodsDal.Read();
        }
    }
}
