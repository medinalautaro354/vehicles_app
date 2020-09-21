using BGlobalSolutionsExam.Model.Entities;

namespace BGlobalSolutionsExam.DataTransferObjects.AddDtos
{
    public interface IAddVehicleDto
    {
        string LicensePlate { get; }
        Brand Brand { get; }
        int NumberOfDoors { get; }
        string Owner { get; }
    }
}
