using ASPLab_P.Controllers;
using ASPLab_P.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;
using Xunit;

namespace ASPLab_P.Test
{
    public class BranchControllerTests
    {
        // Test dla akcji Index
        [Fact]
        public void Index_ReturnsViewResult_WithListOfBranches()
        {
            // Arrange
            var mockBranchService = new Mock<IBranchService>();
            mockBranchService.Setup(repo => repo.FindAll()).Returns(new List<Branch>());
            var controller = new BranchController(mockBranchService.Object);

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
            Assert.NotNull(result.Model);
            Assert.IsType<List<Branch>>(result.Model);
        }

        // Test dla akcji Create (GET)
        [Fact]
        public void Create_Get_ReturnsViewResult()
        {
            // Arrange
            var mockBranchService = new Mock<IBranchService>();
            var controller = new BranchController(mockBranchService.Object);

            // Act
            var result = controller.Create() as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
        }

        // Test dla akcji Create (POST)
        [Fact]
        public void Create_Post_ValidModelState_ReturnsRedirectToActionResult()
        {
            // Arrange
            var mockBranchService = new Mock<IBranchService>();
            mockBranchService.Setup(repo => repo.Add(It.IsAny<Branch>()));
            var controller = new BranchController(mockBranchService.Object);
            var branch = new Branch();

            // Act
            var result = controller.Create(branch) as RedirectToActionResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Index", result.ActionName);
        }

        [Fact]
        public void Create_Post_InvalidModelState_ReturnsViewResult()
        {
            // Arrange
            var mockBranchService = new Mock<IBranchService>();
            var controller = new BranchController(mockBranchService.Object);
            controller.ModelState.AddModelError("Name", "Required");
            var branch = new Branch();

            // Act
            var result = controller.Create(branch) as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
        }

        // Test dla akcji Edit (GET)
        [Fact]
        public void Edit_Get_ReturnsViewResult_WithBranch()
        {
            // Arrange
            var mockBranchService = new Mock<IBranchService>();
            mockBranchService.Setup(repo => repo.FindById(It.IsAny<int>())).Returns(new Branch());
            var controller = new BranchController(mockBranchService.Object);

            // Act
            var result = controller.Edit(1) as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
            Assert.NotNull(result.Model);
            Assert.IsType<Branch>(result.Model);
        }

        [Fact]
        public void Edit_Get_ReturnsNotFound_WhenBranchIsNull()
        {
            // Arrange
            var mockBranchService = new Mock<IBranchService>();
            mockBranchService.Setup(repo => repo.FindById(It.IsAny<int>())).Returns((Branch)null);
            var controller = new BranchController(mockBranchService.Object);

            // Act
            var result = controller.Edit(1) as NotFoundResult;

            // Assert
            Assert.NotNull(result);
            Assert.IsType<NotFoundResult>(result);
        }

        // Test dla akcji Edit (POST)
        [Fact]
        public void Edit_Post_ValidModelState_ReturnsRedirectToActionResult()
        {
            // Arrange
            var mockBranchService = new Mock<IBranchService>();
            mockBranchService.Setup(repo => repo.Edit(It.IsAny<Branch>()));
            var controller = new BranchController(mockBranchService.Object);
            var branch = new Branch();

            // Act
            var result = controller.Edit(branch) as RedirectToActionResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Index", result.ActionName);
        }

        [Fact]
        public void Edit_Post_InvalidModelState_ReturnsViewResult()
        {
            // Arrange
            var mockBranchService = new Mock<IBranchService>();
            var controller = new BranchController(mockBranchService.Object);
            controller.ModelState.AddModelError("Name", "Required");
            var branch = new Branch();

            // Act
            var result = controller.Edit(branch) as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
        }

        // Test dla akcji Detalis
        [Fact]
        public void Details_ReturnsViewResult_WithBranch()
        {
            // Arrange
            var mockBranchService = new Mock<IBranchService>();
            mockBranchService.Setup(repo => repo.FindById(It.IsAny<int>())).Returns(new Branch());
            var controller = new BranchController(mockBranchService.Object);

            // Act
            var result = controller.Detalis(1) as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
            Assert.NotNull(result.Model);
            Assert.IsType<Branch>(result.Model);
        }

        // Test dla akcji Delete (GET)
        [Fact]
        public void Delete_Get_ReturnsViewResult_WithBranch()
        {
            // Arrange
            var mockBranchService = new Mock<IBranchService>();
            mockBranchService.Setup(repo => repo.FindById(It.IsAny<int>())).Returns(new Branch());
            var controller = new BranchController(mockBranchService.Object);

            // Act
            var result = controller.Delete(1) as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
            Assert.NotNull(result.Model);
            Assert.IsType<Branch>(result.Model);
        }

        [Fact]
        public void Delete_Get_ReturnsNotFound_WhenBranchIsNull()
        {
            // Arrange
            var mockBranchService = new Mock<IBranchService>();
            mockBranchService.Setup(repo => repo.FindById(It.IsAny<int>())).Returns((Branch)null);
            var controller = new BranchController(mockBranchService.Object);

            // Act
            var result = controller.Delete(1) as NotFoundResult;

            // Assert
            Assert.NotNull(result);
            Assert.IsType<NotFoundResult>(result);
        }

        // Test dla akcji Delete (POST)
        [Fact]
        public void Delete_Post_ReturnsRedirectToActionResult()
        {
            // Arrange
            var mockBranchService = new Mock<IBranchService>();
            mockBranchService.Setup(repo => repo.DeleteById(It.IsAny<int>()));
            var controller = new BranchController(mockBranchService.Object);
            var branch = new Branch();

            // Act
            var result = controller.Delete(branch) as RedirectToActionResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Index", result.ActionName);
        }
    }
}
