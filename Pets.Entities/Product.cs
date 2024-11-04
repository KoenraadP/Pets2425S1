using System;
using System.ComponentModel.DataAnnotations;
using Pets.Entities.Validators;

namespace Pets.Entities
{
    // alle properties die bij iedere categorie / ieder product horen
    // plaats je in deze algemene Product class
    public class Product
    {
        // Guid of int zijn beide OK voor id
        // int is makkelijker, Guid is meer future proof
        [Key]
        public Guid ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]  
        public decimal Price { get; set; }
        public int AmountInStock { get; set; }
        public bool InStock { get; set; }
        // AnimalType is een enum
        public AnimalType AnimalType { get; set; }
        // Brand is een andere 'entity' class
        // Guid apart linken voor makkelijkere validatie 
        [Required(ErrorMessage = "Please select a brand.")]
        [GuidNotEmpty(ErrorMessage = "Please select a valid brand.")]
        public Guid BrandId { get; set; }
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

        public Product(Guid productId, string name, string description,
            decimal price, int amountInStock, AnimalType animalType)
        {
            ProductId = productId;
            Name = name;
            Description = description;
            Price = price;
            AmountInStock = amountInStock;
            // bool heeft als default value false
            if (AmountInStock > 0) InStock = true;
            AnimalType = animalType;
        }
    }
}
