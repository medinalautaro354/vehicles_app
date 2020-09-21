using BGlobalSolutionsExam.DataTransferObjects.Factories.Dtos;
using BGlobalSolutionsExam.Model.Entities;

namespace BGlobalSolutionsExam.DataTransferObjects.Factories.Mappers
{
    class VehicleDtoMapper : MapperEntityBase<IVehicle, VehicleDto>
    {
        protected override void MapEntityToDtoBase<T>(IVehicle entity, T dto)
        {
            dto.Id = entity.Id;
            dto.IsActive = entity.IsActive;
            dto.LicensePlate = entity.LicensePlate;
            dto.NumberOfDoors = entity.NumberOfDoors;
            dto.Owner = entity.Owner;
            dto.BrandId = (int)entity.Brand;
        }

        public void MapBrand(VehicleDto dto, string brandName)
        {
            dto.Brand = brandName;
        }
    }
}
