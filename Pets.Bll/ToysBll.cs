using Pets.Dal;
using Pets.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets.Bll
{
    public static class ToysBll
    {
        public static bool Create(string name, string description, decimal price,
            int amountInStock, bool inStock, string selectedBrand)
        {
            Toy t = new Toy(Guid.NewGuid(),name,description,price,amountInStock,AnimalType.Cat);
            Guid brandId = Guid.Parse(selectedBrand);
            return ToysDal.Create(t, brandId);
        }

        public static List<Toy> Read()
        {
            return ToysDal.Read();
        }
    }
}
