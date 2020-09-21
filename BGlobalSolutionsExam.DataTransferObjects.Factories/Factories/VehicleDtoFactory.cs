using BGlobalSolutionsExam.DataTransferObjects.Factories.Dtos;
using BGlobalSolutionsExam.DataTransferObjects.Factories.Mappers;
using BGlobalSolutionsExam.DataTransferObjects.ReadDtos;
using BGlobalSolutionsExam.Model.Entities;

namespace BGlobalSolutionsExam.DataTransferObjects.Factories.Factories
{
    public class VehicleDtoFactory
    {
        private readonly VehicleDtoMapper mapper = new VehicleDtoMapper();

        public IVehicleDto MapEntityToDto(IVehicle vehicle, string brandName)
        {
            var dto = mapper.CreateDtoBase<VehicleDto>(vehicle);
            mapper.MapBrand(dto, brandName);

            return dto;
        }
    }
}
