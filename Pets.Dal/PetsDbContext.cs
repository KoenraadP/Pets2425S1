﻿using Pets.Entities;
using System.Data.Entity;

namespace Pets.Dal
{
    internal class PetsDbContext : DbContext
    {
        // eigen toestel
        public PetsDbContext() : base(@"Data Source=.\SQLEXPRESS;Initial Catalog=Pets2425S1;Integrated Security=True")
        {

        }

        // creo toestel
        //public PetsDbContext() : base(@"Data Source =.\sqlexpress; Initial Catalog=Pets2425S1;User ID = creo; Password = creo")
        //{

        //}

        public DbSet<Food> Foods { get; set; }
        public DbSet<Toy> Toys { get; set; }
        public DbSet<Brand> Brands { get; set; }

        // Stap 1: Migraties inschakelen --> dit moet je slechts één keer doen
        // EntityFramework6\Enable-Migrations

        // Stap 2: Voeg een migratie toe --> elke keer je iets verandert aan je Entities classes
        // EntityFramework6\Add-Migration naam

        // Stap 3: Update de database --> altijd nadat je eerst Add-Migration (stap 2) gedaan hebt
        // EntityFramework6\Update-Database
    }
}
