using ASPLab_P.Controllers;
using ASPLab_P.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ASPLab_P.Test
{
    public class EmployeeControllerTests
    {

        [Fact]
        public void Create_Post_WithValidModel_RedirectsToIndex()
        {
            // Arrange
            var mockEmployeeService = new Mock<IEmployeeService>();
            var validEmployee = new Employee { Name = "John", LastName = "Doe" };
            var controller = new EmployeeController(mockEmployeeService.Object);

            // Act
            var result = controller.Create(validEmployee) as RedirectToActionResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Index", result.ActionName);
        }
        [Fact]
        public void Edit_Get_ReturnsViewResult_WithEmployeeModel()
        {
            // Arrange
            var mockEmployeeService = new Mock<IEmployeeService>();
            mockEmployeeService.Setup(repo => repo.FindById(It.IsAny<int>())).Returns(new Employee());
            var controller = new EmployeeController(mockEmployeeService.Object);
            var id = 1;

            // Act
            var result = controller.Edit(id) as ViewResult;
            var model = result?.Model as Employee;

            // Assert
            Assert.NotNull(result);
            Assert.NotNull(model);
            Assert.IsType<Employee>(model);
        }

        // Test dla akcji AdvancedEdit (GET)
        [Fact]
        public void AdvancedEdit_Get_ReturnsViewResult_WithEmployeeModel()
        {
            // Arrange
            var mockEmployeeService = new Mock<IEmployeeService>();
            mockEmployeeService.Setup(repo => repo.FindById(It.IsAny<int>())).Returns(new Employee());
            var controller = new EmployeeController(mockEmployeeService.Object);
            var id = 1;

            // Act
            var result = controller.AdvancedEdit(id) as ViewResult;
            var model = result?.Model as Employee;

            // Assert
            Assert.NotNull(result);
            Assert.NotNull(model);
            Assert.IsType<Employee>(model);
        }

        // Test dla akcji Fire (GET)
        [Fact]
        public void Fire_Get_ReturnsViewResult_WithEmployeeModel()
        {
            // Arrange
            var mockEmployeeService = new Mock<IEmployeeService>();
            mockEmployeeService.Setup(repo => repo.FindById(It.IsAny<int>())).Returns(new Employee());
            var controller = new EmployeeController(mockEmployeeService.Object);
            var id = 1;

            // Act
            var result = controller.Fire(id) as ViewResult;
            var model = result?.Model as Employee;

            // Assert
            Assert.NotNull(result);
            Assert.NotNull(model);
            Assert.IsType<Employee>(model);
        }

        // Test dla akcji Delete (GET)
        [Fact]
        public void Delete_Get_ReturnsViewResult_WithEmployeeModel()
        {
            // Arrange
            var mockEmployeeService = new Mock<IEmployeeService>();
            mockEmployeeService.Setup(repo => repo.FindById(It.IsAny<int>())).Returns(new Employee());
            var controller = new EmployeeController(mockEmployeeService.Object);
            var id = 1;

            // Act
            var result = controller.Delete(id) as ViewResult;
            var model = result?.Model as Employee;

            // Assert
            Assert.NotNull(result);
            Assert.NotNull(model);
            Assert.IsType<Employee>(model);
        }
        [Fact]
        public void Edit_Post_ValidModelState_ReturnsRedirectToActionResult()
        {
            // Arrange
            var mockEmployeeService = new Mock<IEmployeeService>();
            mockEmployeeService.Setup(repo => repo.Edit(It.IsAny<Employee>()));
            var controller = new EmployeeController(mockEmployeeService.Object);
            var employee = new Employee { Id = 1 };

            // Act
            var result = controller.Edit(employee) as RedirectToActionResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Index", result.ActionName);
        }

        // Test dla akcji Fire (POST)
        [Fact]
        public void Fire_Post_ValidModelState_ReturnsRedirectToActionResult()
        {
            // Arrange
            var mockEmployeeService = new Mock<IEmployeeService>();
            mockEmployeeService.Setup(repo => repo.Edit(It.IsAny<Employee>()));
            var controller = new EmployeeController(mockEmployeeService.Object);
            var employee = new Employee { Id = 1 };

            // Act
            var result = controller.Fire(employee) as RedirectToActionResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Index", result.ActionName);
        }

        // Test dla akcji Delete (POST)
        [Fact]
        public void Delete_Post_ValidModelState_ReturnsRedirectToActionResult()
        {
            // Arrange
            var mockEmployeeService = new Mock<IEmployeeService>();
            mockEmployeeService.Setup(repo => repo.DeleteById(It.IsAny<int>()));
            var controller = new EmployeeController(mockEmployeeService.Object);
            var employee = new Employee { Id = 1 };

            // Act
            var result = controller.Delete(employee) as RedirectToActionResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Index", result.ActionName);
        }
    }
}
