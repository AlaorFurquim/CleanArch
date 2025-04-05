using CleanArch.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Entities
{
    public sealed class Product : Base
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int Stock { get; private set; }
        public string Image { get; private set; }

        public Product(string name, string description, decimal price, int stock, string image)
        {
            ValidadeDoamin(name, description, price, stock, image);
        }

        public Product(int id,string name, string description, decimal price, int stock, string image)
        {
            DomainExceptionValidation.when(id < 0, "Invalid value id.");
            Id = id;
            ValidadeDoamin(name, description, price, stock, image);
        }

        public void Update(string name, string description, decimal price, int stock, string image, int categoryId)
        {
            ValidadeDoamin(name, description, price, stock, image);
            CategoryId = categoryId;
        }


        public void ValidadeDoamin(string name, string description, decimal price, int stock, string image)
        {
            DomainExceptionValidation.when(string.IsNullOrEmpty(name), "Invalid name. Name is requered");

            DomainExceptionValidation.when(name.Length < 5, "Invalid name, too short, minimum 3 characters");

            DomainExceptionValidation.when(string.IsNullOrEmpty(description), "Invalid description. Name is requered");

            DomainExceptionValidation.when(description.Length < 250, "Invalid description, too short, minimum 3 characters");

            DomainExceptionValidation.when(price < 0, "Invalid value price.");

            DomainExceptionValidation.when(stock < 0, "Invalid value stock.");

            DomainExceptionValidation.when(string.IsNullOrEmpty(image), "Invalid image. Name is requered");

            DomainExceptionValidation.when(image?.Length > 250, "Invalid image, too long, maximum 250 characters");

            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
            Image = image;

        }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
