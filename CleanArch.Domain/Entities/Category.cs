using CleanArch.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Entities
{
    public sealed class Category : Base
    {
        public string Name { get; private set; }

        public Category(string name)
        {
           ValidateDomain(name);
        }

        public Category(int id,string name)
        {
            DomainExceptionValidation.when(id < 0,"Invalid value id.");
            Id = id;
            ValidateDomain(name);
        }

        public void Update(string name)
        {
            ValidateDomain(name);
        }

        public ICollection<Product> Products { get; set; }

        private void ValidateDomain(string name)
        {
            DomainExceptionValidation.when(string.IsNullOrEmpty(name), "Invalid name. Name is requered");

            DomainExceptionValidation.when(name.Length < 3, "Invalid name, too short, minimum 3 characters");

            Name = name;
        }
    }
}
