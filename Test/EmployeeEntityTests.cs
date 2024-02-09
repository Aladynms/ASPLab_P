using Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace Data.Tests
{
    public class EmployeeEntityTests
    {
        [Fact]
        public void EmployeeId_ShouldHaveKeyAttribute()
        {
            // Arrange
            var employee = new EmployeeEntity();

            // Act
            var property = employee.GetType().GetProperty("EmployeeId");

            // Assert
            Assert.NotNull(property);
            Assert.True(property.IsDefined(typeof(KeyAttribute), false));
        }

        [Theory]
        [InlineData("", "Doe", "12345678901", "john.doe@example.com", "123456789", 1, 1)]
        [InlineData("John", "", "12345678901", "john.doe@example.com", "123456789", 1, 1)]
        [InlineData("John", "Doe", "", "john.doe@example.com", "123456789", 1, 1)]
        [InlineData("John", "Doe", "12345678901", "", "123456789", 1, 1)]
        public void Employee_ShouldValidateRequiredFields(string name, string lastName, string pesel, string email, string phone, int position, int branchId)
        {
            // Arrange
            var employee = new EmployeeEntity
            {
                Name = name,
                LastName = lastName,
                PESEL = pesel,
                Email = email,
                Phone = phone,
                Position = position,
                BranchId = branchId,
                DateOfEmployment = DateTime.Now
            };

            // Act
            var validationResults = ValidateModel(employee);

            // Assert
            Assert.NotEmpty(validationResults);
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
