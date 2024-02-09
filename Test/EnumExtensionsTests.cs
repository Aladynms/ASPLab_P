using ASPLab_P.Models;
using System;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace ASPLab_P.Test
{
    public class EnumExtensionsTests
    {
        [Fact]
        public void GetDisplayName_ReturnsCorrectDisplayName()
        {
            // Arrange
            var enumValue = Position.Manager;
            var expectedDisplayName = "Kierownik";

            // Act
            var actualDisplayName = enumValue.GetDisplayName();

            // Assert
            Assert.Equal(expectedDisplayName, actualDisplayName);
        }

        [Fact]
        public void GetDisplayName_ThrowsExceptionIfNoDisplayAttribute()
        {
            // Arrange
            var enumValue = TestEnum.NoDisplay;

            // Act & Assert
            Assert.Throws<NullReferenceException>(() => enumValue.GetDisplayName());
        }

        // TestEnum is a dummy enum with no Display attribute
        private enum TestEnum
        {
            NoDisplay
        }
    }
}
