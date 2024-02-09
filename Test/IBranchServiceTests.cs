using ASPLab_P.Models;
using Data.Entities;
using Moq;
using System.Collections.Generic;
using Xunit;

namespace ASPLab_P.Test
{
    public class IBranchServiceTests
    {
        [Fact]
        public void Add_CallsRepositoryMethod()
        {
            // Arrange
            var mockBranchService = new Mock<IBranchService>();
            var branch = new Branch();

            // Act
            mockBranchService.Object.Add(branch);

            // Assert
            mockBranchService.Verify(s => s.Add(branch), Times.Once);
        }

        [Fact]
        public void DeleteById_CallsRepositoryMethod()
        {
            // Arrange
            var mockBranchService = new Mock<IBranchService>();
            var id = 1;

            // Act
            mockBranchService.Object.DeleteById(id);

            // Assert
            mockBranchService.Verify(s => s.DeleteById(id), Times.Once);
        }

        [Fact]
        public void Edit_CallsRepositoryMethod()
        {
            // Arrange
            var mockBranchService = new Mock<IBranchService>();
            var branch = new Branch();

            // Act
            mockBranchService.Object.Edit(branch);

            // Assert
            mockBranchService.Verify(s => s.Edit(branch), Times.Once);
        }

        [Fact]
        public void FindAll_CallsRepositoryMethod()
        {
            // Arrange
            var mockBranchService = new Mock<IBranchService>();

            // Act
            mockBranchService.Object.FindAll();

            // Assert
            mockBranchService.Verify(s => s.FindAll(), Times.Once);
        }

        [Fact]
        public void FindById_CallsRepositoryMethod()
        {
            // Arrange
            var mockBranchService = new Mock<IBranchService>();
            var id = 1;

            // Act
            mockBranchService.Object.FindById(id);

            // Assert
            mockBranchService.Verify(s => s.FindById(id), Times.Once);
        }
    }
}
