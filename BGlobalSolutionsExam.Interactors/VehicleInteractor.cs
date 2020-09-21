using BGlobalSolutionsExam.DataTransferObjects.Factories.Factories;
using BGlobalSolutionsExam.DataTransferObjects.ReadDtos;
using BGlobalSolutionsExam.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BGlobalSolutionsExam.Interactors
{
    public class VehicleInteractor
    {
        private readonly IVehicleReadOnlyRepository repository;
        private readonly VehicleDtoFactory factory;

        public VehicleInteractor(IVehicleReadOnlyRepository repository, VehicleDtoFactory factory)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
            this.factory = factory ?? throw new ArgumentNullException(nameof(factory));
        }

        public async Task<IEnumerable<IVehicleDto>> GetActives()
        {
            var results = await repository.GetActives();

            return results.Select(f => factory.MapEntityToDto(f, f.Brand.ToString()));
        }
    }
}
