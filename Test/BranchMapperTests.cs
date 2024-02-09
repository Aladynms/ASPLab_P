using ASPLab_P.Mappers;
using ASPLab_P.Models;
using Data.Entities;
using Xunit;

namespace ASPLab_P.Test
{
    public class BranchMapperTests
    {
        [Fact]
        public void FromEntity_ConvertsEntityToModel()
        {
            // Arrange
            var entity = new BranchEntity
            {
                BranchId = 1,
                Title = "Branch Title",
                Address = new Address
                {
                    City = "City",
                    Street = "Street",
                    Number = "123",
                    PostalCode = "12345",
                    Region = "Region",
                    Country = "Country"
                }
            };

            // Act
            var model = BranchMapper.FromEntity(entity);

            // Assert
            Assert.Equal(entity.BranchId, model.BranchId);
            Assert.Equal(entity.Title, model.Title);
            Assert.Equal(entity.Address.City, model.City);
            Assert.Equal(entity.Address.Street, model.Street);
            Assert.Equal(entity.Address.Number, model.Number);
            Assert.Equal(entity.Address.PostalCode, model.PostalCode);
            Assert.Equal(entity.Address.Region, model.Region);
            Assert.Equal(entity.Address.Country, model.Country);
        }

        [Fact]
        public void ToEntity_ConvertsModelToEntity()
        {
            // Arrange
            var model = new Branch
            {
                BranchId = 1,
                Title = "Branch Title",
                City = "City",
                Street = "Street",
                Number = "123",
                PostalCode = "12345",
                Region = "Region",
                Country = "Country"
            };

            // Act
            var entity = BranchMapper.ToEntity(model);

            // Assert
            Assert.Equal(model.BranchId, entity.BranchId);
            Assert.Equal(model.Title, entity.Title);
            Assert.Equal(model.City, entity.Address.City);
            Assert.Equal(model.Street, entity.Address.Street);
            Assert.Equal(model.Number, entity.Address.Number);
            Assert.Equal(model.PostalCode, entity.Address.PostalCode);
            Assert.Equal(model.Region, entity.Address.Region);
            Assert.Equal(model.Country, entity.Address.Country);
        }
    }
}
