using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets.Entities
{
    public class Toy : Product
    {
        public Toy()
        {

        }

        public Toy(Guid productId, string name, string description, decimal price, int amountInStock, AnimalType animalType) : base(productId, name, description, price, amountInStock, animalType)
        {

        }

    }
}
