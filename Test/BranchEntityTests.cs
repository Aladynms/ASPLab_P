using Data.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace Data.Tests
{
    public class BranchEntityTests
    {
        [Fact]
        public void BranchId_ShouldHaveKeyAttribute()
        {
            // Arrange
            var branch = new BranchEntity();

            // Act
            var property = branch.GetType().GetProperty("BranchId");

            // Assert
            Assert.NotNull(property);
            Assert.True(property.IsDefined(typeof(KeyAttribute), false));
        }

        [Fact]
        public void Title_ShouldBeRequired()
        {
            // Arrange
            var branch = new BranchEntity();

            // Act
            var validationResults = ValidateModel(branch);

            // Assert
            Assert.Contains("The Title field is required.", validationResults);
        }

        [Fact]
        public void Address_ShouldBeNullByDefault()
        {
            // Arrange
            var branch = new BranchEntity();

            // Assert
            Assert.Null(branch.Address);
        }

        // Helper method to validate the model
        private static List<string> ValidateModel(object model)
        {
            var validationResults = new List<ValidationResult>();
            var context = new ValidationContext(model, serviceProvider: null, items: null);
            Validator.TryValidateObject(model, context, validationResults, validateAllProperties: true);

            var validationErrors = new List<string>();
            foreach (var validationResult in validationResults)
            {
                validationErrors.Add(validationResult.ErrorMessage);
            }

            return validationErrors;
        }
    }
}
