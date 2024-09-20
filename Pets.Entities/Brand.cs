using System;
using System.Collections.Generic;

namespace Pets.Entities
{
    public class Brand
    {
        public Guid BrandId { get; set; }
        public string Name { get; set; }
        // link met products --> een brand kan meerdere products maken/leveren
        public List<Product> Products { get; set; }

        public Brand()
        {
            Products = new List<Product>();
        }

        public Brand(Guid brandId, string name)
        {
            BrandId = brandId;
            Name = name;
            Products = new List<Product>();
        }
    }
}
