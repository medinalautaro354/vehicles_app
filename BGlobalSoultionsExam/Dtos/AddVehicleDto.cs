using BGlobalSolutionsExam.DataTransferObjects.AddDtos;
using BGlobalSolutionsExam.Model.Entities;

namespace BGlobalSolutionsExam.Dtos
{
    public class AddVehicleDto : IAddVehicleDto
    {
        public string LicensePlate { get; set; }
        public Brand Brand { get; set; }
        public int NumberOfDoors { get; set; }
        public string Owner { get; set; }
    }
}
