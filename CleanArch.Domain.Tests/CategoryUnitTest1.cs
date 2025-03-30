using CleanArch.Domain.Entities;
using FluentAssertions;

namespace CleanArch.Domain.Tests
{
    public class CategoryUnitTest1
    {
        [Fact]
        public void CrateCategory_WithValidParameters_ResultsObjetctValidState()
        {
            Action action = () => new Category(1,"Category Name");
            action.Should().NotThrow<CleanArch.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact]
        public void CrateCategory_NegativeValue_ResultsObjetctValidState()
        {
            Action action = () => new Category(-1, "Category Name");
            action.Should().Throw<CleanArch.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid value id.");
        }
        [Fact]
        public void CrateCategory_ShortNameValue_ResultsObjetctValidState()
        {
            Action action = () => new Category(1, "Ca");
            action.Should().Throw<CleanArch.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name, too short, minimum 3 characters");
        }
        [Fact]
        public void CrateCategory_MissingNameValue_ResultsObjetctValidState()
        {
            Action action = () => new Category(1, "");
            action.Should().Throw<CleanArch.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name. Name is requered");
        }
    }
}