using ASPLab_P.Models;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace ASPLab_P.Test
{
    public class PositionEnumTests
    {
        [Fact]
        public void PositionEnum_DisplayNames_AreCorrect()
        {
            // Arrange
            var expectedNames = new string[]
            {
                "Kierownik",
                "Starszy specjalista",
                "Specjalista",
                "M³odszy specjalista",
                "Pracownik",
                "Praktykant"
            };

            // Act
            var actualNames = new string[]
            {
                Position.Manager.GetDisplayName(),
                Position.Senior_specialist.GetDisplayName(),
                Position.Specialist.GetDisplayName(),
                Position.Junior_specialist.GetDisplayName(),
                Position.Employee.GetDisplayName(),
                Position.Apprentice.GetDisplayName()
            };

            // Assert
            Assert.Equal(expectedNames, actualNames);
        }
    }
}
