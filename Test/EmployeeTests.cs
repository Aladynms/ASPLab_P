using ASPLab_P.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace ASPLab_P.Tests.Models
{
    public class EmployeeTests
    {
        [Fact]
        public void Name_Required()
        {
            // Arrange
            var employee = new Employee();

            // Act
            var result = ValidateModel(employee);

            // Assert
            Assert.Contains(result, v => v.MemberNames.Contains("Name") && v.ErrorMessage == "Pole 'Imiê' nie mo¿e byæ puste");
        }

        [Fact]
        public void Name_MaxLength()
        {
            // Arrange
            var employee = new Employee
            {
                Name = new string('x', 31) // Exceeds maximum length of 30 characters
            };

            // Act
            var result = ValidateModel(employee);

            // Assert
            Assert.Contains(result, v => v.MemberNames.Contains("Name") && v.ErrorMessage == "Przekroczono max iloœæ znaków (max 30 znaków)");
        }

        [Fact]
        public void LastName_Required()
        {
            // Arrange
            var employee = new Employee();

            // Act
            var result = ValidateModel(employee);

            // Assert
            Assert.Contains(result, v => v.MemberNames.Contains("LastName") && v.ErrorMessage == "Pole 'Nazwisko' nie mo¿e byæ puste");
        }

        [Fact]
        public void LastName_MaxLength()
        {
            // Arrange
            var employee = new Employee
            {
                LastName = new string('x', 31) // Exceeds maximum length of 30 characters
            };

            // Act
            var result = ValidateModel(employee);

            // Assert
            Assert.Contains(result, v => v.MemberNames.Contains("LastName") && v.ErrorMessage == "Przekroczono max iloœæ znaków (max 30 znaków)");
        }

        // Additional test methods for other properties can be added as needed

        private static List<ValidationResult> ValidateModel(object model)
        {
            var validationResults = new List<ValidationResult>();
            var context = new ValidationContext(model, serviceProvider: null, items: null);
            Validator.TryValidateObject(model, context, validationResults, validateAllProperties: true);
            return validationResults;
        }
    }
}
