using BGlobalSolutionsExam.Dtos;
using BGlobalSolutionsExam.Interactors.Persistances;
using BGlobalSolutionsExam.Model.Entities;
using BGlobalSolutionsExam.Repositories.EntityFramework;
using Microsoft.EntityFrameworkCore;
using BGlobalSolutionsExam.Repositories.EntityFramework.Repositories;
using System.Threading.Tasks;
using Xunit;

namespace BGlobalSolutionsExam.Interactors.Tests
{
    public class AddInteractorTest : ConfigureDatabaseOptionsTest
    {
        private readonly VehicleRepository repository;
        private readonly AddVehicleInteractor interactor;
        public AddInteractorTest() : base(new DbContextOptionsBuilder<BGlobalSolutionsContext>()
                .UseInMemoryDatabase("exam").Options)
        {
            var dbContext = new BGlobalSolutionsContext(ContextOptions);

            repository = new VehicleRepository(dbContext);

            interactor = new AddVehicleInteractor(repository);
        }

        [Fact]
        public async Task Can_Create_Vehicle()
        {
            var dto = new AddVehicleDto
            {
                Brand = Brand.Audi,
                LicensePlate = "ASD123",
                NumberOfDoors = 5,
                Owner = "Pedro Picapiedra"
            };

            var entity = await interactor.Add(dto);

            Assert.Equal(1, entity.Id);
        }
    }
}
