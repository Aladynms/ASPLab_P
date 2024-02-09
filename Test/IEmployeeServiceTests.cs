using ASPLab_P.Models;
using Data.Entities;
using Moq;
using System.Collections.Generic;
using Xunit;

namespace ASPLab_P.Test
{
    public class IEmployeeServiceTests
    {
        [Fact]
        public void Add_CallsRepositoryMethod()
        {
            // Arrange
            var mockEmployeeService = new Mock<IEmployeeService>();
            var employee = new Employee();

            // Act
            mockEmployeeService.Object.Add(employee);

            // Assert
            mockEmployeeService.Verify(s => s.Add(employee), Times.Once);
        }

        [Fact]
        public void DeleteById_CallsRepositoryMethod()
        {
            // Arrange
            var mockEmployeeService = new Mock<IEmployeeService>();
            var id = 1;

            // Act
            mockEmployeeService.Object.DeleteById(id);

            // Assert
            mockEmployeeService.Verify(s => s.DeleteById(id), Times.Once);
        }

        [Fact]
        public void Edit_CallsRepositoryMethod()
        {
            // Arrange
            var mockEmployeeService = new Mock<IEmployeeService>();
            var employee = new Employee();

            // Act
            mockEmployeeService.Object.Edit(employee);

            // Assert
            mockEmployeeService.Verify(s => s.Edit(employee), Times.Once);
        }

        [Fact]
        public void FindAll_CallsRepositoryMethod()
        {
            // Arrange
            var mockEmployeeService = new Mock<IEmployeeService>();

            // Act
            mockEmployeeService.Object.FindAll();

            // Assert
            mockEmployeeService.Verify(s => s.FindAll(), Times.Once);
        }

        [Fact]
        public void FindById_CallsRepositoryMethod()
        {
            // Arrange
            var mockEmployeeService = new Mock<IEmployeeService>();
            var id = 1;

            // Act
            mockEmployeeService.Object.FindById(id);

            // Assert
            mockEmployeeService.Verify(s => s.FindById(id), Times.Once);
        }

        [Fact]
        public void FindAllBranches_CallsRepositoryMethod()
        {
            // Arrange
            var mockEmployeeService = new Mock<IEmployeeService>();

            // Act
            mockEmployeeService.Object.FindAllBranches();

            // Assert
            mockEmployeeService.Verify(s => s.FindAllBranches(), Times.Once);
        }
    }
}
