using Pets.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Pets.Dal
{
    public static class ToysDal
    {
        public static bool Create(Toy t, Guid brandId)
        {
            using (var db = new PetsDbContext())
            {
                try
                {
                    // Brand opzoeken in tabel van Brands
                    Brand b = db.Brands.Find(brandId);
                    // Brand instellen bij food product
                    t.Brand = b;
                    db.Toys.Add(t);
                    return db.SaveChanges() > 0;
                }
                catch
                {
                    return false;
                }
            }
        }

        public static List<Toy> Read()
        {
            using (var db = new PetsDbContext())
            {
                return db.Toys.ToList();
            }
        }
    }
}
