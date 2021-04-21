using MyEcommerce.Core.DomainObjects;
using System;

namespace MyEcommerce.Catalog.Domain
{
    public class Product : Entity, IAgregateRoot
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public bool Active { get; private set; }
        public decimal Value { get; private set; }
        public DateTime Register { get; private set; }
        public string Image { get; private set; }
        public int StockQuantity { get; private set; }
        public Guid CategoryId { get; private set; }
        public Category Category { get; private set; }

        public Product(string name, string description, bool active, decimal value, DateTime register, string image, Guid categoryId)
        {
            Name = name;
            Description = description;
            Active = active;
            Value = value;
            Register = register;
            Image = image;
            CategoryId = categoryId;
        }

        public void Activate() => Active = true;

        public void Inactivate() => Active = false;

        public void DebitStock(int quantity) => StockQuantity -= Math.Abs(quantity);

        public void AddStock(int quantity) => StockQuantity += Math.Abs(quantity);

        public bool ExistsStock(int quantity) => StockQuantity >= Math.Abs(quantity);

        public void ChangeCategory(Category category)
        {
            Category = category;
            CategoryId = category.Id;
        }
    }
}