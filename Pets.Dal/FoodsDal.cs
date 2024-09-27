using Pets.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pets.Dal
{
    public static class FoodsDal
    {
        public static bool Create(Food f, Guid brandId)
        {
            using (var db = new PetsDbContext())
            {
                try
                {
                    // Brand opzoeken in tabel van Brands
                    Brand b = db.Brands.Find(brandId);
                    // Brand instellen bij food product
                    f.Brand = b;
                    db.Foods.Add(f);
                    return db.SaveChanges() > 0;
                }
                catch
                {
                    return false;
                }
            }
        }

        public static List<Food> Read()
        {
            using (var db = new PetsDbContext())
            {
                return db.Foods.ToList();
            }
        }
    }
}
