using System;

namespace Pets.Entities
{
    // alle properties die bij iedere categorie / ieder product horen
    // plaats je in deze algemene Product class
    public class Product
    {
        // Guid of int zijn beide OK voor id
        // int is makkelijker, Guid is meer future proof
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int AmountInStock { get; set; }
        public bool InStock { get; set; }
        // AnimalType is een enum
        public AnimalType AnimalType { get; set; }
        // Brand is een andere 'entity' class
        public Brand Brand { get; set; }

        // lege constructors zijn nodig voor sommige bewerkingen
        public Product()
        {
            
        }

        // constructor met alle nodige info
        public Product(Guid productId, string name, string description, 
            decimal price, int amountInStock, AnimalType animalType, Brand brand)
        {
            ProductId = productId;
            Name = name;
            Description = description;
            Price = price;
            AmountInStock = amountInStock;
            // bool heeft als default value false
            if (AmountInStock > 0) InStock = true;
            AnimalType = animalType;
            Brand = brand;
        }
    }
}
