using ASPLab_P.Models;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace ASPLab_P.Tests.Models
{
    public class BranchTests
    {
        [Fact]
        public void Title_Required()
        {
            // Arrange
            var branch = new Branch();

            // Act
            var result = ValidateModel(branch);

            // Assert
            Assert.Contains(result, v => v.MemberNames.Contains("Title") && v.ErrorMessage == "Pole 'Tytu³' nie mo¿e byæ puste");
        }

        [Fact]
        public void Title_MaxLength()
        {
            // Arrange
            var branch = new Branch
            {
                Title = new string('x', 51) // Exceeds maximum length of 50 characters
            };

            // Act
            var result = ValidateModel(branch);

            // Assert
            Assert.Contains(result, v => v.MemberNames.Contains("Title") && v.ErrorMessage == "Przekroczono maksymaln¹ d³ugoœæ pola (maksymalnie 50 znaków)");
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void City_Required(string city)
        {
            // Arrange
            var branch = new Branch
            {
                City = city
            };

            // Act
            var result = ValidateModel(branch);

            // Assert
            Assert.Contains(result, v => v.MemberNames.Contains("City") && v.ErrorMessage == "Pole 'Miasto' nie mo¿e byæ puste");
        }

        // Additional test methods for other properties can be added as needed

        private static System.Collections.Generic.List<ValidationResult> ValidateModel(object model)
        {
            var validationResults = new System.Collections.Generic.List<ValidationResult>();
            var context = new ValidationContext(model, serviceProvider: null, items: null);
            Validator.TryValidateObject(model, context, validationResults, validateAllProperties: true);
            return validationResults;
        }
    }
}
