using CleanArch.Domain.Entities;
using FluentAssertions;
namespace CleanArch.Domain.Tests
{
    public class ProductUnitTest1
    {
        [Fact]
        public void CrateProduct_WithValidParameters_ResultsObjetctValidState()
        {
            Action action = () => new Product(1, "Product Name","Product description",9.99m,99,"product image");
            action.Should().NotThrow<CleanArch.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact]
        public void CrateProduct_NegativeValidParameters_DomainExptionIvalidId()
        {
            Action action = () => new Product(-1, "Product Name", "Product description", 9.99m, 99, "product image");
            action.Should().Throw<CleanArch.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid Id Value");
        }

        [Fact]
        public void CrateProduct_ShortNameValue_DomainExptionIvalidId()
        {
            Action action = () => new Product(1, "Pr", "Product description", 9.99m, 99, "product image");
            action.Should().Throw<CleanArch.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid Name, too short, minimum 3 characters");
        }


        [Fact]
        public void CrateProduct_LongImageName_DomainExptionIvalidId()
        {
            Action action = () => new Product(1, "Product", "Product description", 9.99m, 99, @"product image ooooooooooo
            oooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo");
            action.Should().Throw<CleanArch.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid Image Name, too long,Maximum 250 characters");
        }


        [Theory]
        [InlineData(-5)]
        public void CrateProduct_InvalidStockValue_DomainExptionIvalidId(int value)
        {
            Action action = () => new Product(1, "Pro", "Product description", 9.99m,value, @"product image");
            action.Should().Throw<CleanArch.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid stock value");
        }

    }

}
