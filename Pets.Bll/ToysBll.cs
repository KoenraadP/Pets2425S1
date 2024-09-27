using Pets.Dal;
using Pets.Entities;
using System.Collections.Generic;
using System;

namespace Pets.Bll
{
    public static class ToysBll
    {
        public static bool Create(string name, string description, decimal price,
            int amountInStock, bool inStock, string selectedBrand)
        {
            Toy t = new Toy(Guid.NewGuid(), name, description, price,
                amountInStock, AnimalType.Cat, ToySize.Small);
            // Brand id string omzetten naar Guid
            Guid brandId = Guid.Parse(selectedBrand);
            // Brand Guid id meegeven naar Dal Create methode
            return ToysDal.Create(t, brandId);
        }

        public static List<Toy> Read()
        {
            return ToysDal.Read();
        }
    }
}
