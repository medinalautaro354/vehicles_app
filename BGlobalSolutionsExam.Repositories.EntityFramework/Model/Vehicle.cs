using BGlobalSolutionsExam.Model.Entities;

namespace BGlobalSolutionsExam.Repositories.EntityFramework.Model
{
    public class Vehicle : IVehicle
    {
        public int Id { get; set; }
        public string LicensePlate { get; set; }
        public Brand Brand { get; set; }
        public int NumberOfDoors { get; set; }
        public string Owner { get; set; }
        public bool IsActive { get ; set ; }
    }
}
