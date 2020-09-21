using BGlobalSolutionsExam.Model.Entities;

namespace BGlobalSolutionsExam.Repositories.Entities
{
    public interface IVehicleAdd
    {
        string LicensePlate { get; }
        Brand Brand { get; }
        int NumberOfDoors { get; }
        string Owner { get; }
    }
}
