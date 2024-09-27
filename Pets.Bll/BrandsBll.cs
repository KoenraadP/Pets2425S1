using Pets.Dal;
using Pets.Entities;
using System;
using System.Collections.Generic;

namespace Pets.Bll
{
    public static class BrandsBll
    {
        public static bool Create(string name)
        {
            Brand b = new Brand(Guid.NewGuid(), name);
            return BrandsDal.Create(b);
        }

        public static List<Brand> Read()
        {
            return BrandsDal.Read();
        }
    }
}
