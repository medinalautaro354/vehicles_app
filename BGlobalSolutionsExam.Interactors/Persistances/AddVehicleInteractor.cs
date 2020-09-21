using BGlobalSolutionsExam.DataTransferObjects.AddDtos;
using BGlobalSolutionsExam.Model.Entities;
using BGlobalSolutionsExam.Repositories.Entities;
using BGlobalSolutionsExam.Repositories.Repositories;
using System;
using System.Threading.Tasks;

namespace BGlobalSolutionsExam.Interactors.Persistances
{
    public partial class AddVehicleInteractor
    {
        public class VehicleAdd : IVehicleAdd
        {
            public string LicensePlate { get; set; }
            public Brand Brand { get; set; }
            public int NumberOfDoors { get; set; }
            public string Owner { get; set; }

            public VehicleAdd(IAddVehicleDto dto)
            {
                LicensePlate = dto.LicensePlate;
                Brand = dto.Brand;
                NumberOfDoors = dto.NumberOfDoors;
                Owner = dto.Owner;
            }
        }
    }

    public partial class AddVehicleInteractor
    {
        private readonly IVehicleRepository vehicleRepository;

        public AddVehicleInteractor(IVehicleRepository vehicleRepository)
        {
            this.vehicleRepository = vehicleRepository ?? throw new ArgumentNullException(nameof(vehicleRepository));
        }

        public async Task<IVehicle> Add(IAddVehicleDto dto)
        {
            var entity = await vehicleRepository.Add(new VehicleAdd(dto));

            return entity;
        }
    }
}
