using ASPLab_P.Mappers;
using ASPLab_P.Models;
using Data.Entities;
using Xunit;

namespace ASPLab_P.Test
{
    public class EmployeeMapperTests
    {
        [Fact]
        public void FromEntity_ConvertsEntityToModel()
        {
            // Arrange
            var entity = new EmployeeEntity
            {
                EmployeeId = 1,
                Name = "John",
                LastName = "Doe",
                PESEL = "12345678901",
                Email = "john.doe@example.com",
                Phone = "123-456-789",
                Position = 1,
                BranchId = 1,
                DateOfEmployment = new System.DateTime(2023, 1, 1),
                DateOfDismissal = new System.DateTime(2024, 1, 1)
            };

            // Act
            var model = EmployeeMapper.FromEntity(entity);

            // Assert
            Assert.Equal(entity.EmployeeId, model.Id);
            Assert.Equal(entity.Name, model.Name);
            Assert.Equal(entity.LastName, model.LastName);
            Assert.Equal(entity.PESEL, model.PESEL);
            Assert.Equal(entity.Email, model.Email);
            Assert.Equal(entity.Phone, model.Phone);
            Assert.Equal((Position)entity.Position, model.Position);
            Assert.Equal(entity.BranchId, model.BranchId);
            Assert.Equal(entity.DateOfEmployment, model.DateOfEmployment);
            Assert.Equal(entity.DateOfDismissal, model.DateOfDismissal);
        }

        [Fact]
        public void ToEntity_ConvertsModelToEntity()
        {
            // Arrange
            var model = new Employee
            {
                Id = 1,
                Name = "John",
                LastName = "Doe",
                PESEL = "12345678901",
                Email = "john.doe@example.com",
                Phone = "123-456-789",
                Position = Position.Manager,
                BranchId = 1,
                DateOfEmployment = new System.DateTime(2023, 1, 1),
                DateOfDismissal = new System.DateTime(2024, 1, 1)
            };

            // Act
            var entity = EmployeeMapper.ToEntity(model);

            // Assert
            Assert.Equal(model.Id, entity.EmployeeId);
            Assert.Equal(model.Name, entity.Name);
            Assert.Equal(model.LastName, entity.LastName);
            Assert.Equal(model.PESEL, entity.PESEL);
            Assert.Equal(model.Email, entity.Email);
            Assert.Equal(model.Phone, entity.Phone);
            Assert.Equal((int)model.Position, entity.Position);
            Assert.Equal(model.BranchId, entity.BranchId);
            Assert.Equal(model.DateOfEmployment, entity.DateOfEmployment);
            Assert.Equal(model.DateOfDismissal, entity.DateOfDismissal);
        }
    }
}
