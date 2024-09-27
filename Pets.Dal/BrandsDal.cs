using Pets.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Pets.Dal
{
    public static class BrandsDal
    {
        public static bool Create(Brand b)
        {
            using (var db = new PetsDbContext())
            {
                try
                {
                    db.Brands.Add(b);
                    return db.SaveChanges() > 0;
                }
                catch
                {
                    return false;
                }
            }
        }

        public static List<Brand> Read()
        {
            using (var db = new PetsDbContext())
            {
                return db.Brands.ToList();
            }
        }
    }
}
